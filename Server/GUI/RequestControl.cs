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
    public partial class RequestControl : UserControl
    {
        private ServerManager serverManager;
        private ProcessBill processBill = new ProcessBill();
        private ProcessMember processMember = new ProcessMember();  
        private List<Bill> billList;
        public RequestControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
        }
        public void loadBill()
        {
            billList = processBill.getBillList();
            pnlRequestContainer.Controls.Clear();
            foreach(Bill bill in billList)
            {
                RequestMenuItem menuItem = new RequestMenuItem();
                menuItem.Bill = bill;
                pnlRequestContainer.Controls.Add(menuItem);
            }
        }

        private void RequestControl_Load(object sender, EventArgs e)
        {
            loadBill();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ServerManager.checkRequest == 0)
            {
                ServerManager.checkRequest = -1;
                loadBill();
            }
        }
    }
}
