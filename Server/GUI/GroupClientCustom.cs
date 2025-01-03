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
    public partial class GroupClientCustom : Form
    {
        private ProcessGroupClient pcGrClient = new ProcessGroupClient();
        private Boolean add = false;
        public GroupClientCustom()
        {
            InitializeComponent();
        }

        private void GroupClientCustom_Load(object sender, EventArgs e)
        {
            cbxGroupName.DataSource = pcGrClient.getAllGroupClient();
            cbxGroupName.DisplayMember = "GroupName";
            txtDiscription.DataBindings.Clear();
            txtDiscription.DataBindings.Add("Text", cbxGroupName.DataSource, "Description");
            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", cbxGroupName.DataSource, "Price");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxGroupName.Text = string.Empty;
            txtDiscription.Clear();
            txtPrice.Clear();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            add = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbxGroupName.DropDownStyle = ComboBoxStyle.DropDownList;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GroupClient grclient = new GroupClient();
            grclient.GroupName = cbxGroupName.SelectedItem.ToString();
            txtDiscription.Text = grclient.Description;
            txtPrice.Text = grclient.Price;
            if (add)
            {
                pcGrClient.addGroupClient(grclient);
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                add = false;
                GroupClientCustom_Load(sender, e);
            }
            else
            {
                pcGrClient.updateGroupClient(grclient);
                cbxGroupName.DropDownStyle = ComboBoxStyle.DropDown;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GroupClient grclient = new GroupClient();
            grclient.GroupName = cbxGroupName.SelectedItem.ToString();
            txtDiscription.Text = grclient.Description;
            txtPrice.Text = grclient.Price;
            pcGrClient.deleteGroupClient(grclient);
        }
    }
}
