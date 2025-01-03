using Server.BLL;
using Server.DTO;
using Server.socket_configure;
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

namespace Server.GUI 
{
    public partial class BillDetailFrm : Form
    {
        private Bill bill;
        private List<Bill_Item> items;
        ProcessMember ProcessMember = new ProcessMember();
        ProcessProduct ProcessProduct = new ProcessProduct();
        ProcessBill ProcessBill = new ProcessBill();

        public BillDetailFrm(Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
            items = ProcessBill.getBillItemsList(bill.BillID);
        }

        private void loadInfoBill()
        {
            lblBillID.Text = bill.BillID.ToString();
            lblMemberName.Text = ProcessMember.getMemberName(bill.MemberID);
            lblTime.Text = bill.CreatedAt.ToString();
            lblTotalPrice.Text = currencyFormat(bill.TotalPrice);
        }
        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);


        private void BillDetailFrm_Load(object sender, EventArgs e)
        {
            loadInfoBill();
            Label stt = new Label()
            {
                Text = "STT",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
            };
            Label name = new Label()
            {
                Text = "Tên món",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
            };
            Label quantity = new Label()
            {
                Text = "Số lượng",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
            };
            tableLayoutPanel1.Controls.Add(stt, 0, 0);
            tableLayoutPanel1.Controls.Add(name, 1, 0);
            tableLayoutPanel1.Controls.Add(quantity, 2, 0);
            for(int i = 1; i <= items.Count; i++)
            {
                Label n = new Label()
                {
                    Text = i.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                Label proName = new Label()
                {
                    Text = ProcessProduct.getProductName(items[i - 1].ProductID),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                Label quan = new Label()
                {
                    Text = items[i - 1].Quantity.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                tableLayoutPanel1.Controls.Add(n, 0, i);
                tableLayoutPanel1.Controls.Add(proName, 1, i);
                tableLayoutPanel1.Controls.Add(quan, 2, i);

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ServerManager.checkRequest = bill.MemberID;
            this.Close();
            ProcessBill.updateBill(bill, "SUCCESS");
            foreach(Bill_Item item in items) {
                ProcessProduct.updateProductInventory(item.ProductID, item.Quantity);
            }

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            ServerManager.checkRequest = bill.MemberID * (-1) - 1;
            this.Close();
            ProcessBill.updateBill(bill, "FAILED");
        }
    }
}
