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
    public partial class ClientDetailForm : Form
    {
        ServerManager serverManager;
        InfoClient infoClient;
        ProcessMember processMember;
        ProcessClient processClient;
        public ClientDetailForm(ServerManager serverManager, InfoClient infoClient)
        {
            InitializeComponent();
            this.serverManager = serverManager;
            this.infoClient = infoClient;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientDetailForm_Load(object sender, EventArgs e)
        {
            processMember = new ProcessMember();
            processClient = new ProcessClient();
            lblUsername.Text = infoClient.memberName;

            // Định dạng usedTime theo hh:mm
            lblUsedTime.Text = infoClient.usedTime.ToString(@"hh\:mm");

            double totalMoney = processMember.getTotalMoney(infoClient.memberName);
            lblTotalMoney.Text = currencyFormat(totalMoney);
            lblClientName.Text = processClient.getClientName(infoClient.clientIp);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUsername.Text = infoClient.memberName;

            // Định dạng usedTime theo hh:mm
            lblUsedTime.Text = infoClient.usedTime.ToString(@"hh\:mm");

            double totalMoney = processMember.getTotalMoney(infoClient.memberName);
            lblTotalMoney.Text = currencyFormat(totalMoney);
            lblClientName.Text = processClient.getClientName(infoClient.clientIp);
        }


        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);

        private void btnCloseClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            AddMoney_ClientDetailForm addMoneyForm = new AddMoney_ClientDetailForm(infoClient);
            addMoneyForm.ShowDialog();
        }
    }
}
