using Server.BLL;
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
    public partial class MemberChatControl : UserControl
    {
        private InfoClient infoClient;
        private ServerManager serverManager;
        private ProcessClient processClient = new ProcessClient();
        private ProcessMessage processMessage = new ProcessMessage();
        public MemberChatControl(InfoClient info, ServerManager serverManager)
        {
            InitializeComponent();
            this.infoClient = info;
            this.serverManager = serverManager;
            lsvMessage.Columns.Add("", -2, HorizontalAlignment.Left);

        }
        public MemberChatControl()
        {
            InitializeComponent();
        }
        public InfoClient InfoClient
        {
            get { return infoClient; }
            set
            {
                infoClient = value;
                string str = infoClient.memberName + "  -  " + processClient.getClientName(infoClient.clientIp);
                lblMemberName.Text = str;
            }
        }
        public void loadMessage()
        {
            List<string> messages = processMessage.getMessages(infoClient.memberName);
            foreach(string message in messages)
            {
                lsvMessage.Items.Add(new ListViewItem(message));               
            }
            if(lsvMessage.Items.Count > 0)
            {
                lsvMessage.EnsureVisible(lsvMessage.Items.Count - 1);
            }           
        }

        private void MemberChatControl_Load(object sender, EventArgs e)
        {
            loadMessage();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != "")
            {
                ServerManager.sendMess = 2;
                ServerManager.memberName = infoClient.memberName;
                ServerManager.sendMessage = txtMessage.Text;    
            }
        }
    }
}
