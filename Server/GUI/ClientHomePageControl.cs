using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.BLL;
using Server.DTO;
using Server.socket_configure;

namespace Server.GUI
{
    public partial class ClientHomePageControl: UserControl
    {
        ProcessClient ProcessClient = new ProcessClient();
        List<Client> clientList;
        List<InfoClient> infoList;
        ServerManager serverManager;
        public ClientHomePageControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
            infoList = serverManager.arrClient;

        }

        public void loadClientData()
        {
            clientList = ProcessClient.getAllClient();
            pnlContainer.Controls.Clear();
            foreach (Client client in clientList)
            {
                ClientHomePageUserControl clientControl = new ClientHomePageUserControl(serverManager);
                foreach (InfoClient info in infoList)
                {
                    if (info.clientIp == client.ClientIP)
                    {
                        clientControl.Info = info;
                    }
                }
                clientControl.Client = client;
                pnlContainer.Controls.Add(clientControl);
            }
        }
        public void loadTime()
        {
            clientList = ProcessClient.getAllClient();

            foreach (ClientHomePageUserControl control in pnlContainer.Controls)
            {
                // Cập nhật thông tin cho mỗi control
                foreach (InfoClient info in infoList)
                {
                    if (info.clientIp == control.Client.ClientIP)
                    {
                        control.Info = info;

                        // Cập nhật và hiển thị thời gian sử dụng theo định dạng hh:mm
                        string formattedTime = info.usedTime.ToString(@"hh\:mm");
                        // Giả sử bạn có TextBox hoặc một điều khiển nào đó để hiển thị thời gian
                        //control.TimeUsage = formattedTime;  // Nếu có thuộc tính `TimeUsage` trong control
                    }
                }

                // Cập nhật thông tin client cho mỗi control
                foreach (Client client in clientList)
                {
                    if (client.ClientIP == control.Client.ClientIP)
                    {
                        control.Client = client;
                    }
                }
            }
        }


        private void ClientHomePageControl_Load(object sender, EventArgs e)
        {
            loadClientData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadTime();

        }
    }
}
