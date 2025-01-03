namespace Server.GUI
{
    partial class DashBoardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAllAddMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvAddMoney = new System.Windows.Forms.DataGridView();
            this.cbxTimer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(579, 520);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 30);
            this.txtTotalPrice.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng thu:";
            // 
            // txtAllAddMoney
            // 
            this.txtAllAddMoney.Enabled = false;
            this.txtAllAddMoney.Location = new System.Drawing.Point(579, 251);
            this.txtAllAddMoney.Name = "txtAllAddMoney";
            this.txtAllAddMoney.Size = new System.Drawing.Size(200, 30);
            this.txtAllAddMoney.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chi tiết hóa đơn bán lẻ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chi tiết nạp tiền:";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(19, 299);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(760, 215);
            this.dgvBill.TabIndex = 9;
            // 
            // dgvAddMoney
            // 
            this.dgvAddMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddMoney.Location = new System.Drawing.Point(19, 49);
            this.dgvAddMoney.Name = "dgvAddMoney";
            this.dgvAddMoney.RowHeadersWidth = 51;
            this.dgvAddMoney.RowTemplate.Height = 24;
            this.dgvAddMoney.Size = new System.Drawing.Size(760, 196);
            this.dgvAddMoney.TabIndex = 8;
            // 
            // cbxTimer
            // 
            this.cbxTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimer.FormattingEnabled = true;
            this.cbxTimer.Location = new System.Drawing.Point(618, 10);
            this.cbxTimer.Name = "cbxTimer";
            this.cbxTimer.Size = new System.Drawing.Size(161, 33);
            this.cbxTimer.TabIndex = 16;
            this.cbxTimer.SelectedIndexChanged += new System.EventHandler(this.cbxTimer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chi tiết theo:";
            // 
            // DashBoardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTimer);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAllAddMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dgvAddMoney);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoardControl";
            this.Size = new System.Drawing.Size(808, 553);
            this.Load += new System.EventHandler(this.DashBoardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAllAddMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridView dgvAddMoney;
        private System.Windows.Forms.ComboBox cbxTimer;
        private System.Windows.Forms.Label label5;
    }
}
