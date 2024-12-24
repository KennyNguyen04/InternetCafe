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
    public partial class AdminForm : Form
    {
        private LoginForm loginForm;
        ServerManager serverManager;
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(LoginForm loginForm, ServerManager serverManager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.serverManager = serverManager;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát.","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPageForm adminPageForm = new AdminPageForm(loginForm, this, serverManager);
            adminPageForm.ShowDialog();
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void homePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageFrm homePageFrm = new HomePageFrm(loginForm, this, serverManager);
            homePageFrm.ShowDialog();
        }
    }
}
