using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class AddMoneyForm : Form
    {
        ClientForm clientForm;
        ClientManager clientManager;
        public AddMoneyForm(ClientForm mainFormClient, ClientManager clientManager)
        {
            InitializeComponent();
            this.clientForm = mainFormClient;
            this.clientManager = clientManager;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - clientForm.Width, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnAddMoney.Text == "WAITING...")
            {
                this.Hide();
                ClientForm.check = 1;
            }
            else
            {
                ClientForm.check = -1;
                this.Close();
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if (long.Parse(txtMoney.Text) % 10000 == 0)
            {
                if (btnAddMoney.Text == "Hoàn thành" || btnAddMoney.Text == "Không thành công")
                {
                    ClientForm.check = -1;
                    this.Close();
                }
                else
                {
                    clientManager.addMoney(clientManager.userName, double.Parse(txtMoney.Text));
                    btnAddMoney.Text = "WAITING...";
                    btnAddMoney.ForeColor = Color.White;
                    btnAddMoney.Enabled = false;
                    ptbWaiting.Visible = true;
                    txtMoney.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Số tiền nạp phải chia hết cho 10000", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.message == "Add money success")
            {
                ptbWaiting.Visible=false;
                ptbDone.Visible = true;
                btnAddMoney.Text = "Hoàn thành";
                btnAddMoney.ForeColor = Color.White;
                btnAddMoney.Enabled = true;
                btnClose.Visible = false;
                ClientManager.message = "";
                ClientManager.serviceFee += double.Parse(txtMoney.Text);
            }
            if (ClientManager.message == "Add money denied")
            {
                ptbWaiting.Visible=false;
                ptbDeny.Visible = true;
                btnAddMoney.Text = "Không thành công";
                btnAddMoney.ForeColor = Color.White;
                btnAddMoney.BackColor = Color.OrangeRed;
                btnAddMoney.Enabled = true;
                btnClose.Visible = false;
                ClientManager.message = "";
            }
        }
    }
}
