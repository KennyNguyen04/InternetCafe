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
    public partial class MemberAdminControl : UserControl
    {
        public MemberAdminControl()
        {
            InitializeComponent();
        }
        Member member = new Member();
        bool addMember = false;
        ProcessMember pcMember = new ProcessMember();
        ProcessAddMoney ProcessAddMoney = new ProcessAddMoney();
        ProcessBill ProcessBill = new ProcessBill();
        ProcessMessage ProcessMessage = new ProcessMessage();
        public void getDataMember()
        {
            
            member.Id = int.Parse(txtMemberID.Text);
            member.AccountName = txtAccountName.Text; 
            member.Password = txtPassword.Text;
            member.GroupUser = "Member";
            member.CurrentMoney = double.Parse(nbMoney.Value.ToString());
            member.StatusAccount = cbStatus.SelectedItem.ToString();

        }
        private void MemberAdminControl_Load(object sender, EventArgs e)
        {
            dtgvMember.DataSource = pcMember.getMember();
            cbStatus.SelectedIndex = 0;
        }

        private void dtgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberID.DataBindings.Clear();
            txtMemberID.DataBindings.Add("Text", dtgvMember.DataSource, "MemberID");
            txtAccountName.DataBindings.Clear();
            txtAccountName.DataBindings.Add("Text", dtgvMember.DataSource, "AccountName");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dtgvMember.DataSource, "Password");
            nbMoney.DataBindings.Clear();
            nbMoney.DataBindings.Add("Text", dtgvMember.DataSource, "CurrentMoney");
            string status = dtgvMember.CurrentRow.Cells["MemberStatus"].Value.ToString();

            if (status.Equals("ALLOW"))
            {
                cbStatus.SelectedIndex = 0;
            }
            else
            {
                cbStatus.SelectedIndex = 1;
            }
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            btnSuaHV.Enabled = false;
            btnXoaHV.Enabled = false;
            txtMemberID.Text="100";
            txtMemberID.Enabled = false;
            txtAccountName.Clear();
            txtPassword.Clear();
            cbStatus.SelectedIndex = 0;
            txtAccountName.Focus();
            nbMoney.Value = 0;
            addMember = true;
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;
            txtAccountName.Enabled = false;
            txtPassword.Focus();
            btnThemHV.Enabled = false;
            btnXoaHV.Enabled = false;
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            getDataMember();
            if(MessageBox.Show("Bạn có chắc chắn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ServerManager.memberName = txtAccountName.Text;
                ServerManager.forceLogout = 1;
                ProcessAddMoney.deleteTransaction(txtAccountName.Text);
                ProcessBill.deleteBill(txtAccountName.Text);
                ProcessMessage.deleteMessage(txtAccountName.Text);
                pcMember.deleteMember(member);
            }            
            MemberAdminControl_Load(sender, e);
        }

        private void btnLuuHV_Click(object sender, EventArgs e)
        {
            getDataMember();
            if (addMember)
            {
                if (pcMember.checkSave(member))
                {
                    pcMember.addMember(member);

                }
                addMember = false;
                btnSuaHV.Enabled = true;
                btnXoaHV.Enabled = true;
                ServerManager.forceLogout =1;
                ServerManager.memberName = txtAccountName.Text;

            }
            else
            {
                pcMember.updateMember(member);
                btnThemHV.Enabled = true;
                btnXoaHV.Enabled = true;
                txtAccountName.Enabled = true;
                txtMemberID.Enabled = true;
                ServerManager.forceLogout=1;
                ServerManager.memberName = txtAccountName.Text;
            }
            MemberAdminControl_Load(sender, e);
        }
    }
}
