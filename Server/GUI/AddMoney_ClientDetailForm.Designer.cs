namespace Server.GUI
{
    partial class AddMoney_ClientDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMoney_ClientDetailForm));
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.txtMoney = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.txtMoney);
            this.gbMember.Controls.Add(this.label1);
            this.gbMember.Location = new System.Drawing.Point(38, 29);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(386, 98);
            this.gbMember.TabIndex = 0;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "usename";
            // 
            // txtMoney
            // 
            this.txtMoney.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMoney.Location = new System.Drawing.Point(163, 37);
            this.txtMoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(120, 26);
            this.txtMoney.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền cần nạp";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(98, 145);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(101, 32);
            this.btnAddMoney.TabIndex = 1;
            this.btnAddMoney.Text = "Xác nhận";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddMoney_ClientDetailForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(478, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.gbMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMoney_ClientDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddMoney_ClientDetailForm_Load);
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown txtMoney;
    }
}