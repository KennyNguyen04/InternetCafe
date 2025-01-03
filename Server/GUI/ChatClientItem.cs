using Server.BLL;
using Server.DTO;
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
    public partial class ChatClientItem : UserControl
    {
        private InfoClient info;
        private ProcessClient processClient = new ProcessClient();
        private MemberChatControl memberChatControl;
        public ChatClientItem(MemberChatControl memberChatControl)
        {
            InitializeComponent();
            this.memberChatControl = memberChatControl;
        }
        public InfoClient Info
        {
            get { return info; }
            set { 
                info = value;
                lblUserName.Text = info.memberName;
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            
            memberChatControl.BringToFront();
        }
    }
}
