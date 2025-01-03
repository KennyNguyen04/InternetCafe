using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class BillForm : Form
    {
        List<Cart> listCart;
        ClientManager clientManager;
        DateTime time;
        public BillForm(ClientManager clientManager, DateTime time)
        {
            InitializeComponent();
            this.clientManager = clientManager;
            this.time = time;
            listCart = MenuForm.listCart;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
            ClientForm.checkOrderStatus = 1;
            lblMemberName.Text = clientManager.userName; 
            lblTime.Text = time.ToString();
            lblTotalPrice.Text = currencyFormat(getTotalPrice(listCart));
            Label lbl1 = new Label() { Text = "STT", TextAlign = ContentAlignment.MiddleCenter};
            Label lbl2 = new Label() { Text = "Tên món", TextAlign = ContentAlignment.MiddleCenter};
            Label lbl3 = new Label() { Text = "Số lượng", TextAlign = ContentAlignment.MiddleCenter, AutoSize = true};
            Label lbl4 = new Label() { Text = "Thành tiền", TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl3, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl4, 3, 0);
            tableLayoutPanel1.RowCount = listCart.Count;
            for(int i = 1; i <= listCart.Count; i++)
            {
                Label stt = new Label();
                stt.Text = (i).ToString();
                stt.TextAlign = ContentAlignment.MiddleCenter;
                Label name = new Label();
                name.AutoSize  = true;
                name.Text = listCart[i - 1].Product.ProductName;
                Label quantity = new Label();
                quantity.Text = listCart[i - 1].Quantity.ToString();
                quantity.TextAlign = ContentAlignment.MiddleCenter;
                Label money = new Label();
                double m = listCart[i - 1].Quantity * listCart[i - 1].Product.Price;
                money.Text = m.ToString();
                tableLayoutPanel1.Controls.Add(stt, 0, i);
                tableLayoutPanel1.Controls.Add(name, 1, i);
                tableLayoutPanel1.Controls.Add(quantity, 2, i);
                tableLayoutPanel1.Controls.Add(money, 3, i);
            }
        }
        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);
        private double getTotalPrice(List<Cart> list)
        {
            double s = 0;
            foreach (Cart cart in list)
            {
                s += (cart.Product.Price * cart.Quantity);
            }
            return s;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.message == "Order success")
            {
                ClientManager.serviceFee += getTotalPrice(listCart);
                ClientManager.message = "";
                ptbWaiting.Visible = false;
                ptbSuccess.Visible = true;
                lblStaff.Text = clientManager.staffName;
                lblStatus.Text = "Đã hoàn thành";
                btnAccept.Visible = true;
            }
            if(ClientManager.message == "Order Denied")
            {
                ClientManager.message = "";
                ptbDeny.Visible = true;
                ptbWaiting.Visible = false;
                lblStaff.Text = clientManager.staffName;
                lblStatus.Text = "Giao dịch thất bại";
                btnAccept.Visible = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ClientForm.checkOrderStatus = 0;
            this.Close();
        }
    }
}
