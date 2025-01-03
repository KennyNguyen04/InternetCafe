using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Server.BLL;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Server.socket_configure
{
    public class ServerManager
    {
        IPEndPoint iP;
        Socket socketServer;
        public List<InfoClient> arrClient;
        const int portCode = 1660;
        const int maxGetByte = 1024 * 5000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        const string wait = "WAITING";
        const string USING = "USING";
        public double totalMoney;
        public List<Socket> clientList;
        public double clientPrice;
        public static double addMoney = -1;
        public static string userName = "";
        public static int sendMess = -1;
        public static string sendMessage = "";
        public AddMoneyTransaction addMoneyTransaction;
        private ProcessMember ProcessMember = new ProcessMember();
        private ProcessClient ProcessClient = new ProcessClient();
        private ProcessGroupClient ProcessGroupClient = new ProcessGroupClient();
        private ProcessAddMoney ProcessAddMoney = new ProcessAddMoney();
        private ProcessMessage ProcessMessage = new ProcessMessage();
        private ProcessProduct ProcessProduct = new ProcessProduct();
        private ProcessBill ProcessBill = new ProcessBill();
        private ProcessUser ProcessUser = new ProcessUser();
        public List<DTO.Product> listProduct;
        public List<string> listCategory = new List<string>();
        public List<Bill_Item> listItems = new List<Bill_Item>();
        public static string memberName = "";
        public static int checkRequest = -1;
        public static int forceLogout = -1;
        public ServerManager()
        {
            arrClient = new List<InfoClient>();
            iP = new IPEndPoint(IPAddress.Any, portCode);
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socketServer.Bind(iP);
            Thread OkeFine = new Thread(StartAceptClient);
            OkeFine.IsBackground = true;
            OkeFine.Start();

            
        }
        public void StartAceptClient()
        {
            try
            {
                while (true)
                {
                    socketServer.Listen(100);
                    Socket newClient = socketServer.Accept();
                    Thread listenClient = new Thread(ReceiveDataFromClient);
                    listenClient.IsBackground = true;
                    listenClient.Start(newClient);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ReceiveDataFromClient(object obj)
        {
            Socket currentClient = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] messegeFromClient = new byte[1024 * 5000];
                    currentClient.Receive(messegeFromClient);
                    string messege = (string)CovertToMessege(messegeFromClient);
                    List<string> lstMessage = messege.Split('|').ToList();
                    IPEndPoint remoteEndPoint = (IPEndPoint)currentClient.RemoteEndPoint;
                    IPAddress clientIpAddress = remoteEndPoint.Address;
                    if (lstMessage[request].Equals("ConnectWithMePls!!"))
                    {
                        arrClient.Add(
                        new InfoClient()
                        {
                            clientIp = clientIpAddress.ToString(),
                            stateClient = "WAITING",
                            client = currentClient,
                            usedTime = TimeSpan.Zero                           
                        }) ;
                        refreshClient = change;
                        ChangeStateClient(currentClient, "WAITING", "");
                        List<Client> list  = ProcessClient.getAllClient();
                        listProduct = ProcessProduct.getAllProducts();
                        listCategory = ProcessProduct.getAllCategory();
                        currentClient.Send(ConvertToByte("Send Category" + listCategoryToString(listCategory)));
                        currentClient.Send(ConvertToByte("Send Menu" + listProductsToString(listProduct)));
                    }
                    if (lstMessage[request].Equals("AllowToLogInPls!!"))
                    {
                        foreach(InfoClient cli in arrClient)
                        {
                            if(cli.memberName == lstMessage[1])
                            {
                                currentClient.Send(ConvertToByte("Loged In Another Client|"));
                            }
                            else
                            {
                                if (ProcessMember.checkLoginMember(lstMessage[1], lstMessage[2]))
                                {
                                    if (ProcessMember.checkValidMember(lstMessage[1]))
                                    {
                                        totalMoney = ProcessMember.getTotalMoney(lstMessage[1]);
                                        foreach (InfoClient cli1 in arrClient)
                                        {
                                            if (cli1.client == currentClient)
                                            {
                                                cli1.memberName = lstMessage[1];
                                                string groupClientName = ProcessClient.getGroupName(cli);
                                                this.clientPrice = ProcessGroupClient.getClientPrice(groupClientName);
                                            }
                                        }
                                        currentClient.Send(ConvertToByte("OkePlayGo|" + lstMessage[1] + "|" + totalMoney + "|" + clientPrice + "|"));
                                        ChangeStateClient(currentClient, "MEMBER USING", lstMessage[1]);
                                        sendMess = 1;
                                    }
                                    else
                                    {
                                        currentClient.Send(ConvertToByte("Your account is exhausted.Recharge to use it!!!"));
                                    }
                                }
                                else
                                {
                                    currentClient.Send(ConvertToByte("Account not exist !! Or Wrong Username, Password"));
                                    ChangeStateClient(currentClient, "WAITING", lstMessage[1]);
                                }
                            }
                        }


                    }
                    if (lstMessage[request].Equals("UpdateMoney"))
                    {
                        ProcessMember.updateCurrentMoney(lstMessage[1], double.Parse(lstMessage[2]));
                        foreach (InfoClient cli in arrClient)
                        {
                            if (cli.client == currentClient)
                            {
                                cli.usedTime = TimeSpan.Parse(lstMessage[3]);
                            }
                        }
                        if (double.Parse(lstMessage[2]) == 0)
                        {
                            currentClient.Send(ConvertToByte("No Money, Log out|"));
                        }
                    }
                    if (lstMessage[request].Equals("LogOutPls!!"))
                    {

                        currentClient.Send(ConvertToByte("OKLogout"));
                        ChangeStateClient(currentClient, "WAITING", "");
                        sendMess = 1;
                    }
                    if (lstMessage[request].Equals("ChangePass"))
                    {
                        if (ProcessMember.checkLoginMember(lstMessage[1], lstMessage[2])){
                            if (ProcessMember.updateNewPass(lstMessage[1], lstMessage[3]))
                            {
                                currentClient.Send(ConvertToByte("ChangePassSuccess"));
                            }
                        }
                        else
                        {
                            currentClient.Send(ConvertToByte("WrongCurrentPassword"));
                        }
                    }
                    if (lstMessage[request].Equals("AddMoney"))
                    {
                        addMoneyTransaction = new AddMoneyTransaction();
                        string currentTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        foreach(InfoClient info in arrClient)
                        {
                            if (info.client == currentClient)
                            {
                                addMoneyTransaction.ClientIP = info.clientIp;
                            }
                        }
                        addMoneyTransaction.TransacDate = DateTime.Now;
                        addMoneyTransaction.Status = "WAITING";
                        addMoneyTransaction.UserName = userName;
                        addMoneyTransaction.MemberName = lstMessage[1];
                        addMoneyTransaction.AddMoney = double.Parse(lstMessage[2]);
                        if (ProcessAddMoney.insertAddMoney(addMoneyTransaction)){
                            addMoney = 0;
                            currentClient.Send(ConvertToByte("WaitForAdding"));
                        }
                    }
                    if (lstMessage[request].Equals("Message"))
                    {
                        arrClient = infoClients(lstMessage[1]);
                        if(ProcessMessage.insertMessage(arrClient.ElementAt(0), userName, lstMessage[2], "member"))
                        {
                            sendMess = 1;
                        }
                        

                    }
                    if(sendMess == 2)
                    {
                        arrClient = infoClients(lstMessage[1]);
                        foreach (InfoClient info in arrClient)
                        {
                            if(info.client == currentClient && info.memberName == memberName) {
                                if (ProcessMessage.insertMessage(info, userName, sendMessage, "server"))
                                {
                                    sendMess = 1;
                                    
                                    currentClient.Send(ConvertToByte("Server send message|" + sendMessage));
                                    
                                }
                            }
                        }
                        memberName = "";
                        sendMessage = "";
                    }
                    if (addMoney != 0 && addMoney != -1)
                    {
                        foreach(InfoClient info in arrClient)
                        {
                            if(memberName.ToLower() ==  info.memberName.ToLower() && info.client == currentClient)
                            {
                                if (addMoney == -2)
                                {
                                    currentClient.Send(ConvertToByte("AddMoneyDenied|"));
                                }
                                else
                                {
                                    if (ProcessMember.addMoney(addMoney, memberName))
                                    {
                                        totalMoney = ProcessMember.getTotalMoney(memberName);
                                    }
                                    currentClient.Send(ConvertToByte("AddMoneySuccess|" + totalMoney.ToString() + "|"));
                                }
                                
                            }                                
                        }
                        addMoney = 0;
                        memberName = "";
                    }
                        
                    if (lstMessage[request].Equals("Send Order")){
                        DateTime createdAt = DateTime.Parse(lstMessage[1]);
                        for(int i = 2; i < lstMessage.Count; i+=2) {
                            int id = int.Parse(lstMessage[i]);
                            int quantity = int.Parse(lstMessage[i + 1]);
                            Bill_Item item = new Bill_Item
                            {
                                ProductID = id,
                                Quantity = quantity
                            };
                            listItems.Add(item);
                        }
                        foreach(InfoClient info in arrClient)
                        {
                            if (info.client == currentClient)
                            {
                                 memberName = info.memberName;
                            }
                        }
                        try
                        {
                            Bill bill = new Bill
                            {
                                MemberID = ProcessMember.getMemberID(memberName),
                                UserID = ProcessUser.getUserId(userName),
                                CreatedAt = createdAt,
                                TotalPrice = getTotalPrice(listItems),
                            };
                            if (ProcessBill.insertBillItem(ProcessBill.insertBill(bill), listItems))
                            {
                                listItems.Clear();
                                checkRequest = 0;
                            }
                            
                        }
                        catch (Exception e) {
                        }
                        memberName = "";
                    }
                    if(checkRequest > 0)
                    {
                        int id = checkRequest;
                        foreach (InfoClient info in arrClient)
                        {
                            if(info.memberName ==  ProcessMember.getMemberName(id).ToLower() && info.client == currentClient)
                            {
                                checkRequest = 0;
                                currentClient.Send(ConvertToByte("Order Success|" + ProcessUser.getUserFullName(userName)));
                            }
                            listProduct = ProcessProduct.getAllProducts();
                            info.client.Send(ConvertToByte("Send Menu" + listProductsToString(listProduct)));
                        }
                        
                    }
                    if(checkRequest < -1)
                    {
                        int id = (checkRequest + 1) * (-1);
                        foreach (InfoClient info in arrClient)
                        {
                            if (info.memberName == ProcessMember.getMemberName(id).ToLower() && info.client == currentClient)
                            {
                                checkRequest = 0;
                                currentClient.Send(ConvertToByte("Order Denied|" + ProcessUser.getUserFullName(userName)));
                            }
                        }
                    }
                    if(forceLogout == 1)
                    {
                        foreach (InfoClient info in arrClient)
                        {
                            if(info.memberName == memberName && info.client == currentClient)
                            {
                                forceLogout = 0;
                                currentClient.Send(ConvertToByte("Force Logout"));
                                memberName = "";
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                foreach (InfoClient cli in arrClient)
                {
                    if (cli.client == currentClient)
                    {
                        cli.stateClient = "DISCONNECT";
                        cli.usedTime = TimeSpan.Zero;
                        ProcessClient.changeStateClient(cli);
                    }
                }
            }

        }
        public void ChangeStateClient(Socket client, string state, string userName)
        {
            foreach (InfoClient cli in arrClient)
            {
                if (cli.client == client)
                {
                    cli.usedTime = TimeSpan.Zero;
                    cli.stateClient = state;
                    cli.memberName = userName;
                    ProcessClient.changeStateClient(cli);
                }
            }
        }

        public List<InfoClient> infoClients(string memberName)
        {
            InfoClient newestChatClient = arrClient.Find(x => x.memberName == memberName);
            arrClient.RemoveAll(x => x.memberName == memberName);
            arrClient.Insert(0, newestChatClient);
            return arrClient;
        }

        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object CovertToMessege(byte[] messege)
        {
            MemoryStream memoryStream = new MemoryStream(messege);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
        public string listProductsToString(List<Product> products)
        {
            string str = "";
            foreach (Product product in products)
            {
                str += "|" + product.ProductID.ToString() + 
                    "|" + product.ProductName + 
                    "|" + product.Category + 
                    "|" + product.Price.ToString() + 
                    "|" + product.InventoryNumber.ToString() + 
                    "|" + product.ImageUrl;
            }
            return str;
        }

        public string listCategoryToString(List<string> list)
        {
            string str = "";
            foreach (string category in list)
            {
                str += "|" + category;
            }
            return str;
        }
        public InfoClient GetInfoClient(string nameClient, string contraint)
        {
            foreach (InfoClient infoClient in arrClient)
            {
                if (infoClient.client.Equals(nameClient) && infoClient.stateClient.Equals(contraint))
                {
                    return infoClient;
                }

            }
            return null;
        }
        public double getTotalPrice(List<Bill_Item> list)
        {
            double totalPrice = 0;
            foreach(Bill_Item item in list)
            {
                totalPrice = totalPrice + ( ProcessProduct.getPrice(item.ProductID) * item.Quantity);
            }
            return totalPrice;
        }
    }
}
