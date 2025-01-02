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
    public partial class LoginFormClient : Form
    {
        ClientManager clientManager;  
        public string userName;
        public LoginFormClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            clientManager = new ClientManager();
        }
        public LoginFormClient(ClientManager x)
        {
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            this.clientManager = x;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát.","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void LoginFormClient_Load(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            Start();
        }
        async Task Start()
        {
            await Task.Delay(1000);
            pnlLogin.Show();
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            clientManager.Login(txtUsername.Text, txtPassword.Text);
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.message == "Login")
            {
                ClientManager.message = "";
                MessageBox.Show("Đăng nhập thành công.","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(ClientManager.message == "Login wrong")
            {
                ClientManager.message = "";
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (ClientManager.message == "Your account is exhausted.Recharge to use it!!!")
            {
                ClientManager.message = "";
                MessageBox.Show("Số tiền trong tài khoản của bạn đã hết.\nVui lòng nạp thêm tiền để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
