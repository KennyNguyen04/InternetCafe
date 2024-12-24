using Server.BLL;
using Server.GUI;
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

namespace Server
{
    public partial class LoginForm : Form
    {
        ProcessUser ProcessUser = new ProcessUser();
        ServerManager serverManager;
        public string userName;
        public LoginForm()
        {
            InitializeComponent();
            serverManager = new ServerManager();
            CheckForIllegalCrossThreadCalls = false;
            /*timerHome.Interval = 1000;
            timerHome.Enabled = true;
            timerHome.Start();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            txtPassword.PasswordChar = '\0';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            txtPassword.PasswordChar = '●';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ProcessUser.checkLoginServer(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ServerManager.userName = txtUsername.Text;
                this.Hide();
                if (ProcessUser.checkIsAdmin(txtUsername.Text))
                {
                    AdminForm adminForm = new AdminForm(this, serverManager);
                    adminForm.ShowDialog();
                }
                else
                {
                    HomePageFrm homePageFrm = new HomePageFrm(this, serverManager);
                    homePageFrm.ShowDialog();
                }
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
