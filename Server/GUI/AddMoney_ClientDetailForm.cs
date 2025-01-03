using Server.BLL;
using Server.DTO;
using Server.socket_configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class AddMoney_ClientDetailForm : Form
    {
        private InfoClient infoClient;
        private AddMoneyTransaction addMoney;
        private ProcessAddMoney processAddMoney = new ProcessAddMoney();
        public AddMoney_ClientDetailForm(InfoClient infoClient)
        {
            InitializeComponent();
            this.infoClient = infoClient;
        }

        private void AddMoney_ClientDetailForm_Load(object sender, EventArgs e)
        {
            gbMember.Text = infoClient.memberName;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if(txtMoney.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền cần nạp.", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (long.Parse(txtMoney.Text) % 10000 != 0)
            {
                MessageBox.Show("Số tiền nạp phải chia hết cho 10000", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ServerManager.addMoney = double.Parse(txtMoney.Text);
                ServerManager.memberName = infoClient.memberName;
                txtMoney.Enabled = false;
                this.addMoney = new AddMoneyTransaction{
                    AddMoney = double.Parse(txtMoney.Text),
                    ClientIP = infoClient.clientIp,
                    MemberName = gbMember.Text,
                    Status = "SUCCESS",
                    TransacDate = DateTime.Now,
                    UserName = ServerManager.userName,
                };
                processAddMoney.insertAddMoney(this.addMoney);
                MessageBox.Show("Nạp tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMoney_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
