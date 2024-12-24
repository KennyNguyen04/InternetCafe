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
    public partial class UserAdminPageControl : UserControl
    {
        public UserAdminPageControl()
        {
            InitializeComponent();
        }
        User user = new User();
        ProcessUser pcUser = new ProcessUser();
        bool addUser= false;
        
        public void getDataUser()
        {
            user.Id = int.Parse(txtUserId.Text);
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.FullName = txtFullname.Text;
            user.Email = txtEmail.Text;
            user.PhoneNumber = txtPhone.Text;
            user.GroupUser = cbGroupUser.SelectedItem.ToString();
        }
        private void UserAdminPageControl_Load(object sender, EventArgs e)
        {
            
            cbGroupUser.SelectedIndex = 0;
            string groupName = cbGroupUser.SelectedItem.ToString();
            if (groupName.Equals("Manager"))
            {
                btnThemUser.Enabled = false;
                btnXoaUser.Enabled = false;
            }
            else if (groupName.Equals("Staff"))
            {
                btnThemUser.Enabled = true;
                btnXoaUser.Enabled = true;
            }
        }

        private void cbGroupUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupName = cbGroupUser.SelectedItem.ToString();
            
            dtgvUsers.DataSource = pcUser.getUseryGroupName(groupName);
            txtUserId.DataBindings.Clear();
            txtUserId.DataBindings.Add("Text", dtgvUsers.DataSource, "UserID");
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", dtgvUsers.DataSource, "UserName");
            txtFullname.DataBindings.Clear();
            txtFullname.DataBindings.Add("Text", dtgvUsers.DataSource, "FullName");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dtgvUsers.DataSource, "PhoneNumber");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvUsers.DataSource, "Email");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dtgvUsers.DataSource, "Password");
            if (groupName.Equals("Manager"))
            {
                btnThemUser.Enabled = false;
                btnXoaUser.Enabled = false;
            }else if (groupName.Equals("Staff"))
            {
                btnThemUser.Enabled = true;
                btnXoaUser.Enabled = true;
            }
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            btnSuaUser.Enabled = false;
            btnXoaUser.Enabled = false;
            txtUserId.Enabled = false;
            txtUserId.Text = "100";
            txtUsername.Clear();
            txtFullname.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtUsername.Focus();
            addUser = true;
        }

        private void btnLuuUser_Click(object sender, EventArgs e)
        {
            getDataUser();
            if (addUser)
            {
                if (pcUser.checkSave(user))
                {
                    pcUser.addUser(user);

                }
                addUser = false;
                btnSuaUser.Enabled = true;
                btnXoaUser.Enabled = true;

            }
            else
            {
                pcUser.updateUser(user);
                btnThemUser.Enabled = true;
                btnXoaUser.Enabled = true;
                txtUsername.Enabled = true;
            }
            UserAdminPageControl_Load(sender, e);
        }

        private void btnSuaUser_Click(object sender, EventArgs e)
        {
            txtUserId.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Focus();
            btnThemUser.Enabled = false;
            btnXoaUser.Enabled = false;
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            getDataUser();
            pcUser.deleteUser(user);
            UserAdminPageControl_Load(sender,e);
        }
    }
}
