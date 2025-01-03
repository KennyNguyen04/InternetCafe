using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Client
{

    public class ClientManager
    {
        IPEndPoint Ip;
        public Socket client;
        int portCode = 1604;
        const int maxGetByte = 1024 * 4000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        public static int requestServer = -1;
        public const int MEMBERLOGIN = 102;
        public const int LOGOUT = 103;
        public LoginFormClient lockScreen;
        public string userName = "";
        public static string message;
        public double totalMoney = -1;
        public double clientPrice;
        public static int checkAddMoney = -1;
        public static string recieveMessage = "";
        public List<Product> productList = new List<Product>();
        public List<string> categoryList = new List<string>();
        public string staffName;
        public static double serviceFee = 0;
        public ClientManager()
        {
            Ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portCode);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(Ip);
                client.Send(ConvertToByte("ConnectWithMePls!!|" + "May-1"));               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Thread listenSever = new Thread(ReceiveDataFromSever);
            listenSever.IsBackground = true;
            listenSever.Start();
            lockScreen = new LoginFormClient(this);
            lockScreen.Show();

        }
        public TimeSpan usedTime { get; set; }


        public void ReceiveDataFromSever()
        {

            try
            {
                bool check = true;
                while (true)
                {
                    byte[] messageFromClient = new byte[maxGetByte];
                    client.Receive(messageFromClient);
                    string msg = CovertToMessage(messageFromClient).ToString();
                    List<string> lstMessage = msg.Split('|').ToList();

                    if (lstMessage[request].Equals("UpdateMoney"))
                    {
                        this.userName = lstMessage[1];
                        this.totalMoney = double.Parse(lstMessage[2]);

                        // Nếu server gửi cả hh:mm:ss, chỉ lấy hh:mm
                        string time = lstMessage[3].Split(':')[0] + ":" + lstMessage[3].Split(':')[1];
                        this.usedTime = TimeSpan.ParseExact(time, @"hh\:mm", null);

                        // Cập nhật giao diện với thời gian đã sử dụng
                        // Cập nhật chi phí nếu cần
                    }



                    if (lstMessage[request].Equals("OkePlayGo"))
                    {
                        this.userName = lstMessage[1];
                        this.totalMoney = double.Parse(lstMessage[2]);
                        this.clientPrice = double.Parse(lstMessage[3]);
                        requestServer = MEMBERLOGIN;
                        message = "Login";
                        lockScreen.Visible = false;
                    }
                    if (lstMessage[request].Equals("Account not exist !! Or Wrong Username, Password"))
                    {
                        message = "Login wrong";
                    }                  

                    if (lstMessage[request].Equals("Your account is exhausted.Recharge to use it!!!"))
                    {
                        lockScreen.Visible = true;
                        message = "Your account is exhausted.Recharge to use it!!!";
                    }
                    if (lstMessage[request].Equals("OKLogout")){
                        lockScreen.Visible = true; 
                    }
                    if (lstMessage[request].Equals("ChangePassSuccess"))
                    {
                        message = "Change pass success";
                    }
                    if (lstMessage[request].Equals("WrongCurrentPassword"))
                    {
                        message = "Wrong password";
                    }
                    if (lstMessage[request].Equals("AddMoneySuccess"))
                    {
                        checkAddMoney = 1;
                        message = "Add money success";
                        totalMoney = double.Parse(lstMessage[1]);
                    }
                    if (lstMessage[request].Equals("AddMoneyDenied"))
                    {
                        checkAddMoney = -1;
                        message = "Add money denied";
                    }
                    if (lstMessage[request].Equals("No Money, Log out"))
                    {
                        requestServer = LOGOUT;
                    }

                   

                    if (lstMessage[request].Equals("Server send message"))
                    {
                        recieveMessage = lstMessage[1];
                    }
                    if (lstMessage[request].Equals("Send Menu"))
                    {
                        productList.Clear();
                        for (int i = 1; i < lstMessage.Count; i = i + 6)
                        {
                            Product p = new Product
                            {
                                ProductID = int.Parse(lstMessage[i]),
                                ProductName = lstMessage[i + 1],
                                Category = lstMessage[i + 2],
                                Price = double.Parse(lstMessage[i + 3]),
                                InventoryNumber = int.Parse(lstMessage[i + 4]),
                                Image = getImageByUrl(lstMessage[i + 5]),
                            };
                            productList.Add(p);
                        }
                    }
                    if (lstMessage[request].Equals("Send Category"))
                    {
                        categoryList.Clear();
                        for(int i = 1; i < lstMessage.Count; i++)
                        {
                            categoryList.Add(lstMessage[i]);
                        }
                        categoryList.Insert(0, "Tất cả");
                    }
                    if (lstMessage[request].Equals("Order Success"))
                    {
                        message = "Order success";
                        staffName = lstMessage[1];
                    }
                    if (lstMessage[request].Equals("Order Denied"))
                    {
                        message = "Order Denied";
                        staffName = lstMessage[1];
                    }
                    if (lstMessage[request].Equals("Force Logout"))
                    {
                        message = "Force Logout";
                        MessageBox.Show("Tài khoản của bạn đã bị buộc đăng xuất.\nVui lòng liên hệ nhân viên để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception e) 
            {
                if(MessageBox.Show("Mất kết nối với máy chủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
                
            }
        }

        public bool CheckBalance(double itemPrice)
        {
            if (totalMoney < itemPrice)
            {
                return false;
            }
            return true;
        }

        public void Login(string userName, string passWord)
        {
            client.Send(ConvertToByte("AllowToLogInPls!!|" + userName + "|" + passWord + "|"));
        }
        public void LogoutMember(string userName)
        {
            client.Send(ConvertToByte("LogOutPls!!|" + userName + "|"));
        }

        public double CalculateCost(TimeSpan timeUsed)
        {
            // Tính phí theo phút
            double costPerMinute = clientPrice / 60; // Chi phí mỗi phút
            double totalCost = costPerMinute * timeUsed.TotalMinutes;
            return totalCost;
        }

        public void updateMoney(string userName, double totalMoney, TimeSpan usedTime)
        {
            double cost = CalculateCost(usedTime); // Tính phí sử dụng
            totalMoney -= cost; // Trừ phí sử dụng từ tổng số tiền

            // Gửi thông tin cập nhật tiền và thời gian đã sử dụng lên server
            string formattedUsedTime = usedTime.ToString(@"hh\:mm");
            client.Send(ConvertToByte($"UpdateMoney|{userName}|{totalMoney}|{formattedUsedTime}|"));
        }


        public void showInfo(string userName)
        {
            client.Send(ConvertToByte("ShowInfo|" + userName + "|"));
        }
        public void changePass(string userName, string currentPass, string newPass)
        {
            client.Send(ConvertToByte("ChangePass|" + userName + "|" + currentPass + "|" + newPass + "|"));
        }
        public void addMoney(string userName, double money){
            client.Send(ConvertToByte("AddMoney|" + userName + "|" + money.ToString() + "|"));
        }
        public void sendMessage(string userName, string message)
        {
            client.Send(ConvertToByte("Message|" + userName + "|" + message));
        }
        public void sendOrder(DateTime time, string order)
        {
            client.Send(ConvertToByte("Send Order|" + time.ToString() + order));
        }
        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object CovertToMessage(byte[] messege)
        {
            MemoryStream memoryStream = new MemoryStream(messege);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
        public Image getImageByUrl(string url)
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(url);
            Bitmap bitmap = new Bitmap(stream);
            return bitmap;
        }
    }
}
