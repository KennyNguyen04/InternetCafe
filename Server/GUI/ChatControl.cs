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
    public partial class ChatControl : UserControl
    {
        private ServerManager serverManager;
        private List<InfoClient> infoList;
        private MemberChatControl memberChatControl;
        public ChatControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
            infoList = serverManager.arrClient;
            /*InfoClient cli = new InfoClient()
            {
                memberName = "thanh bao",
                clientIp = "192.168.1.3",
                stateClient = "MEMBER USING"
            };
            infoList.Add(cli);*/
        }

        private void ChatControl_Load(object sender, EventArgs e)
        {
            loadClientData();
        }
        private void loadClientData()
        {
            pnlMemberContainer.Controls.Clear();
            pnlContainer.Controls.Clear();
            
            foreach(var info in infoList)
            {
                if(info.memberName != "")
                {
                    memberChatControl = new MemberChatControl(info, serverManager);
                    memberChatControl.InfoClient = info;
                    memberChatControl.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(memberChatControl);
                    ChatClientItem item = new ChatClientItem(memberChatControl);
                    item.Info = info;
                    pnlMemberContainer.Controls.Add(item);
                }
                
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ServerManager.sendMess == 1)
            {
                ServerManager.sendMess = -1;
                loadClientData();
            }
        }
    }
}
