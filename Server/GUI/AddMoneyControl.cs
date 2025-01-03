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
    public partial class AddMoneyControl : UserControl
    {
        private ProcessAddMoney ProcessAddMoney = new ProcessAddMoney();
        private List<AddMoneyTransaction> transactionList;
        private ServerManager serverManager;
        public AddMoneyControl(ServerManager serverManager)
        {
            InitializeComponent();
            this.serverManager = serverManager;
        }

        private void AddMoneyControl_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            pnlRequestContainer.Controls.Clear();
            transactionList = ProcessAddMoney.getRequestList();
            foreach (AddMoneyTransaction transaction in transactionList)
            {
                AddMoneyRequestItem item = new AddMoneyRequestItem(serverManager);
                item.AddMoneyTransaction = transaction;
                pnlRequestContainer.Controls.Add(item);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ServerManager.addMoney == 0)
            {
                ServerManager.addMoney = -1;
                loadData();
            }

        }
    }
}
