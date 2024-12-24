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
using System.Xml.Serialization;

namespace Server.GUI
{
    public partial class MemberHomePageControl : UserControl
    {
        ServerManager serverManager;
        ProcessMember ProcessMember = new ProcessMember();
        ProcessAddMoney ProcessAddMoney = new ProcessAddMoney();
        ProcessMessage ProcessMessage = new ProcessMessage();
        ProcessBill ProcessBill = new ProcessBill();
        Member member;        
        AddMoneyTransaction addMoneyTransaction = new AddMoneyTransaction();
        bool addMember = false, updateMember = false, addMoney = false;
        public MemberHomePageControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
        }

        private void MemberHomePageControl_Load(object sender, EventArgs e)
        {
            loadDataMember();
            btnAddMoney.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddMember.Enabled = true;
            btnSave.Enabled = true;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            nudMoney.Enabled = false;
            txtPassword.Clear();
            txtUserName.Clear();
            nudMoney.Value = 0;
        }
        private void loadDataMember()
        {
            dgvMember.DataSource = ProcessMember.getMember();
            dgvMember.Columns["CurrentMoney"].Visible = false;
            dgvMember.Columns["MemberStatus"].Visible = false;
            dgvMember.Columns["GroupUser"].Visible = false;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            addMember = true;
            btnAddMoney.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled= false;
            txtPassword.Enabled = true;
            txtUserName.Enabled = true;
            nudMoney.Enabled = true;
            nudMoney.Text = "0";
            txtUserName.Clear();
            txtPassword.Clear();
        }
        private void getMember()
        {
            member = new Member
            {
                AccountName = txtUserName.Text,
                CurrentMoney = double.Parse(nudMoney.Text),
                Password = txtPassword.Text,
                GroupUser = "Member",
                StatusAccount = "ALLOW"
            };
        }
        private void getAddMoneyTransac()
        {
            addMoneyTransaction = new AddMoneyTransaction {
                MemberName = txtUserName.Text,
                UserName = ServerManager.userName,
                Status = "SUCCESS",
                TransacDate = DateTime.Now,
                AddMoney = double.Parse(nudMoney.Text),
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            getMember();
            if (addMember)
            {
                addMember = false;
                if (ProcessMember.checkSave(member))
                {
                    ProcessMember.addMember(member);
                    getAddMoneyTransac();
                    ProcessAddMoney.insertAddMoneyWithoutClient(addMoneyTransaction);
                }
                
            }
            if (addMoney)
            {
                if (long.Parse(nudMoney.Text) % 10000 == 0)
                {
                    addMoney = false;
                    if (ProcessMember.addMoney(double.Parse(nudMoney.Text), txtUserName.Text))
                    {
                        getAddMoneyTransac();
                        ProcessAddMoney.insertAddMoneyWithoutClient(addMoneyTransaction);
                        ServerManager.addMoney = double.Parse(nudMoney.Text);
                        ServerManager.memberName = txtUserName.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền nạp phải chia hết cho 10000", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (updateMember)
            {
                updateMember = false;
                if(MessageBox.Show("Bạn có chắc chắn đổi mật khẩu","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProcessMember.updateNewPass(txtUserName.Text, txtPassword.Text);
                    ServerManager.forceLogout = 1;
                    ServerManager.memberName = txtUserName.Text;
                }
            }
            MemberHomePageControl_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            getMember();
            if(MessageBox.Show("Bạn có chắc muốn xóa hội viên","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ServerManager.memberName = txtUserName.Text;
                ServerManager.forceLogout = 1;
                ProcessAddMoney.deleteTransaction(txtUserName.Text);
                ProcessBill.deleteBill(txtUserName.Text);
                ProcessMessage.deleteMessage(txtUserName.Text);
                ProcessMember.deleteMember(member);
            }
            MemberHomePageControl_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAddMember.Enabled = false;
            btnDelete.Enabled = false;
            btnAddMoney.Enabled = false;
            txtPassword.Enabled = true;
            updateMember = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                loadDataMember();
            }
            else
            {
                loadDataSearchMember(txtSearch.Text);   
            }
        }
        private void loadDataSearchMember(string memberName)
        {
            dgvMember.DataSource = ProcessMember.searchMember(memberName);
            dgvMember.Columns["CurrentMoney"].Visible = false;
            dgvMember.Columns["MemberStatus"].Visible = false;
        }
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            btnAddMember.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            nudMoney.Enabled = true;
            addMoney = true;
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.DataBindings.Clear();
            txtUserName.DataBindings.Add("Text", dgvMember.DataSource, "AccountName");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dgvMember.DataSource, "Password");
            string status = dgvMember.CurrentRow.Cells["MemberStatus"].Value.ToString();
            lblStatus.Text = status;
            btnAddMoney.Enabled = true;
        }
    }
}
