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
    public partial class HomePageFrm : Form
    {
        LoginForm loginForm = null;
        AdminForm adminForm = null;
        ServerManager serverManager;
        ClientHomePageControl clientControl;
        AddMoneyControl addMoneyControl;
        ChatControl chatControl;
        RequestControl requestControl;
        MemberHomePageControl memberHomePageControl;
        public HomePageFrm()
        {
            InitializeComponent();
        }
        public HomePageFrm(LoginForm loginForm,AdminForm adminForm, ServerManager serverManager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.adminForm = adminForm;
            this.serverManager = serverManager;
        }
        public HomePageFrm(LoginForm loginForm, ServerManager serverManager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.serverManager = serverManager;
            
        }

        private void HomePageFrm_Load(object sender, EventArgs e)
        {
            if(adminForm == null)
            {
                back.Visible = false;
            }
            clientControl = new ClientHomePageControl(serverManager);
            addMoneyControl = new AddMoneyControl(serverManager);
            chatControl = new ChatControl(serverManager);
            requestControl = new RequestControl(serverManager);
            memberHomePageControl = new MemberHomePageControl(serverManager);
            clientControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(clientControl);
            addMoneyControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(addMoneyControl);
            chatControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(chatControl);
            requestControl.Dock = DockStyle .Fill;
            pnlContainer.Controls .Add(requestControl);
            memberHomePageControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(memberHomePageControl);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                loginForm.Show();
            }
        }

        private void clientManage_Click(object sender, EventArgs e)
        {
            clientControl.BringToFront();
        }

        private void MemberManage_Click(object sender, EventArgs e)
        {
            memberHomePageControl.BringToFront();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            requestControl.BringToFront();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            chatControl.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát.","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                Application.Exit();
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddMoney_Click(object sender, EventArgs e)
        {
            addMoneyControl.BringToFront();
        }
    }
}
