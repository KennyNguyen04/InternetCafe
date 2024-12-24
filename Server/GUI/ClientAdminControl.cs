using Server.BLL;
using Server.DTO;
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
    public partial class ClientAdminControl : UserControl
    {
        private ProcessClient pcClient = new ProcessClient();
        private ProcessGroupClient pcGrClient = new ProcessGroupClient();
        Boolean add = false;
        private int x;
        private int y;
        public ClientAdminControl()
        {
            InitializeComponent();

            this.x = this.Location.X + this.Width + 534;
            this.y = this.Location.Y + this.Height - 198;
        }

        private void ClientAdminControl_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = pcClient.GetAllClient();
            dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cbxGrClient.DataSource = pcGrClient.getAllGroupClient();
            cbxGrClient.DisplayMember = "GroupName";

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClientName.DataBindings.Clear();
            txtClientName.DataBindings.Add("Text", dgvClient.DataSource, "ClientName");
            txtClientIP.DataBindings.Clear();
            txtClientIP.DataBindings.Add("Text", dgvClient.DataSource, "ClientIP");
            txtStatus.DataBindings.Clear();
            txtStatus.DataBindings.Add("Text", dgvClient.DataSource, "StatusClient");
            cbxGrClient.DataBindings.Clear();
            cbxGrClient.DataBindings.Add("Text", dgvClient.DataSource, "GroupClientName");

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            add = true;

            txtClientName.Clear();
            txtClientIP.Clear();
            txtStatus.Text = "DISCONNECTED";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            txtClientIP.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Client client = new Client();
            client.ClientName = txtClientName.Text;
            client.ClientIP = txtClientIP.Text;
            client.StatusClient = txtStatus.Text;
            client.GroupClientName = cbxGrClient.Text;
            if (add)
            {
                if (pcClient.checkSave(client))
                {
                    pcClient.addClient(client);
                    add = false;
                    ClientAdminControl_Load(sender, e);
                }
            }
            else
            {
                Client client_2 = new Client();
                client_2.ClientName = txtClientName.Text;
                client_2.ClientIP = txtClientIP.Text;
                client_2.StatusClient = txtStatus.Text;
                client_2.GroupClientName = cbxGrClient.Text;
                pcClient.UpdateClient(client_2);
                btnAdd.Enabled = true;
                txtClientIP.Enabled = true;
                ClientAdminControl_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ClientName = txtClientName.Text;
            client.ClientIP = txtClientIP.Text;
            client.StatusClient = txtStatus.Text;
            client.GroupClientName = cbxGrClient.Text;
            pcClient.DeleteClient(client);
            ClientAdminControl_Load(sender, e);
        }

        private void btnGroupClient_Click(object sender, EventArgs e)
        {
            GroupClientCustom groupClientCustom = new GroupClientCustom();
            groupClientCustom.StartPosition = FormStartPosition.Manual;
            groupClientCustom.Location = new System.Drawing.Point(x, y);
            groupClientCustom.Show();
        }
    }
}
