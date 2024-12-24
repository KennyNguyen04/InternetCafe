using Server.BLL;
using Server.DTO;
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
    public partial class RequestMenuItem : UserControl
    {
        private Bill bill = new Bill();
        private ProcessMember processMember = new ProcessMember();
        private ProcessClient processClient = new ProcessClient();
        private RequestControl requestControl;
        public RequestMenuItem()
        {
            InitializeComponent();
        }
        public Bill Bill
        {
            get { return bill; }
            set 
            { 
                bill = value;
                lblBillID.Text = bill.BillID.ToString();
                lblMemberName.Text = processMember.getMemberName(bill.MemberID);
                lblTime.Text = bill.CreatedAt.ToString();
                lblTotalPrice.Text = currencyFormat(bill.TotalPrice);
            }
        }

        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);

        private void lblBillID_Click(object sender, EventArgs e)
        {
            BillDetailFrm billDetailFrm = new BillDetailFrm(bill);
            billDetailFrm.ShowDialog();
        }
    }
}
