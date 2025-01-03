using Server.BLL;
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
    public partial class DashBoardControl : UserControl
    {
        private ProcessAddMoney pcAddMoney = new ProcessAddMoney();
        private ProcessBill pcBill = new ProcessBill();
        public DashBoardControl()
        {
            InitializeComponent();
        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {
            //cbxTimer.Items.Clear();
            cbxTimer.Items.Add("Tuần");
            cbxTimer.Items.Add("Tháng");
            cbxTimer.SelectedItem = "Tuần";

            string timer = cbxTimer.SelectedItem.ToString();
            fillDatabyTimer(timer);
        }

        private void fillDatabyTimer(string timer)
        {
            if (timer.ToString() == "Tuần")
            {
                dgvAddMoney.DataSource = pcAddMoney.getAllTransactionbyWeek();
                dgvAddMoney.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAddMoney.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvBill.DataSource = pcBill.getAllBillbyWeek();
                dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                txtAllAddMoney.Text = pcAddMoney.getAllAddMoneybyWeek().ToString();
                txtTotalPrice.Text = pcBill.getTotalPricebyWeek().ToString();
            }
            if (timer.ToString() == "Tháng")
            {
                dgvAddMoney.DataSource = pcAddMoney.getAllTransactionbyMonth();
                dgvAddMoney.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAddMoney.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvBill.DataSource = pcBill.getAllBillbyMonth();
                dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                txtAllAddMoney.Text = pcAddMoney.getAllAddMoneybyMonth().ToString();
                txtTotalPrice.Text = pcBill.getTotalPricebyMonth().ToString();
            }
        }

        private void cbxTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string timer = cbxTimer.SelectedItem.ToString();
            fillDatabyTimer(timer);
        }
    }
}
