using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        ClientForm ClientForm;
        ClientManager clientManager;
        public ChatForm(ClientForm clientForm, ClientManager clientManager)
        {
            InitializeComponent();
            this.clientManager = clientManager;
            this.ClientForm = clientForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - ClientForm.Width, 0);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtChat.Text.Length > 0 )
            {
                string str = clientManager.userName + ":\t" + txtChat.Text;
                lstChat.Items.Add(new ListViewItem() { Text = str });
                clientManager.sendMessage(clientManager.userName, txtChat.Text);
                txtChat.Clear();                
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.recieveMessage != "")
            {
                string str = "Server:\t" + ClientManager.recieveMessage;
                lstChat.Items.Add(new ListViewItem() { Text = str});
                ClientManager.recieveMessage = "";
            }
            if(ClientManager.requestServer == -1)
            {
                txtChat.Clear();
                lstChat.Clear();
            }
        }
    }
}
