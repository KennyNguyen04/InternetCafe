using Server.DTO;
using Server.socket_configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class ClientHomePageUserControl : UserControl
    {
        Client client;
        InfoClient info;
        ServerManager serverManager;
        public ClientHomePageUserControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
        }
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
                this.lblClientName.Text = client.ClientName;
                this.lblGroupClient.Text = client.GroupClientName;
                this.lblStatus.Text = client.StatusClient;
            }
        }
        public InfoClient Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;

                // Sử dụng TimeSpan để hiển thị giờ và phút
                this.lblUsedTime.Text = info.usedTime.ToString(@"hh\:mm");
            }
        }

        private void lblGroupClient_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblStatus.Text != "MEMBER USING")
            {
                lblUsedTime.Text = "00:00";
            }
            else
            {
                // Cập nhật lại thời gian sử dụng khi trạng thái là "MEMBER USING"
                if (info != null)
                {
                    lblUsedTime.Text = info.usedTime.ToString(@"hh\:mm");
                }
            }
        }


        private void ClientHomePageUserControl_Click(object sender, EventArgs e)
        {            
        }

        private void tplClient_Click(object sender, EventArgs e)
        {
            
        }

        private void tplClient_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lblClientName_Click(object sender, EventArgs e)
        {
            if(lblStatus.Text == "MEMBER USING")
            {
                ClientDetailForm clientDetailForm = new ClientDetailForm(serverManager, Info);
                clientDetailForm.ShowDialog();
            }
            
        }
    }
}
