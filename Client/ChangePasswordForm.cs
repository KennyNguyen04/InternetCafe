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
    public partial class ChangePasswordForm : Form
    {
        ClientForm ClientForm;
        ClientManager clientManager;
        public ChangePasswordForm()
        {
            InitializeComponent();
            
        }
        public ChangePasswordForm(ClientForm mainFormClient, ClientManager clientManager)
        {
            InitializeComponent();
            this.ClientForm = mainFormClient;
            this.clientManager = clientManager;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || TxtConfirmNewPass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtNewPassword.Text != TxtConfirmNewPass.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clientManager.changePass(lblUsername.Text, txtCurrentPassword.Text, txtNewPassword.Text);
                }
            }
            
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = clientManager.userName;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - ClientForm.Width, 0);
        }

        
        private void HidePassCurrentPass_Click(object sender, EventArgs e)
        {
            HidePassCurrentPass.Visible = false;
            ShowPassCurrentPass.Visible = true;
            txtCurrentPassword.PasswordChar = '●';
        }

        private void HidePassNewPass_Click(object sender, EventArgs e)
        {
            HidePassNewPass.Visible = false;
            ShowPassNewPass.Visible = true;
            txtNewPassword.PasswordChar = '●';
        }

        private void HidePassConfirm_Click(object sender, EventArgs e)
        {
            HidePassConfirm.Visible = false;
            ShowPassConfirm.Visible = true;
            TxtConfirmNewPass.PasswordChar = '●';
        }
        private void ShowPassCurrentPass_Click(object sender, EventArgs e)
        {
            HidePassCurrentPass.Visible = true;
            ShowPassCurrentPass.Visible = false;
            txtCurrentPassword.PasswordChar = '\0';
        }

        private void ShowPassNewPass_Click(object sender, EventArgs e)
        {
            HidePassNewPass.Visible = true;
            ShowPassNewPass.Visible = false;
            txtNewPassword.PasswordChar = '\0';
        }

        private void ShowPassConfirm_Click(object sender, EventArgs e)
        {
            HidePassConfirm.Visible = true;
            ShowPassConfirm.Visible = false;
            TxtConfirmNewPass.PasswordChar = '\0';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ClientManager.message == "Change pass success")
                {
                    ClientManager.message = "";
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (ClientManager.message == "Wrong password")
                {
                    ClientManager.message = "";
                    MessageBox.Show("Sai mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                this.Close();
            }
        }
    }
}
