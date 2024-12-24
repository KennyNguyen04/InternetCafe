namespace Server.GUI
{
    partial class MemberAdminControl
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuuHV = new System.Windows.Forms.Button();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nbMoney = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvMember = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMoney)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuuHV);
            this.panel3.Controls.Add(this.btnXoaHV);
            this.panel3.Controls.Add(this.btnSuaHV);
            this.panel3.Controls.Add(this.btnThemHV);
            this.panel3.Location = new System.Drawing.Point(26, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 101);
            this.panel3.TabIndex = 8;
            // 
            // btnLuuHV
            // 
            this.btnLuuHV.Location = new System.Drawing.Point(550, 25);
            this.btnLuuHV.Name = "btnLuuHV";
            this.btnLuuHV.Size = new System.Drawing.Size(156, 47);
            this.btnLuuHV.TabIndex = 3;
            this.btnLuuHV.Text = "Lưu";
            this.btnLuuHV.UseVisualStyleBackColor = true;
            this.btnLuuHV.Click += new System.EventHandler(this.btnLuuHV_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.Location = new System.Drawing.Point(370, 25);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(156, 47);
            this.btnXoaHV.TabIndex = 2;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.UseVisualStyleBackColor = true;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.Location = new System.Drawing.Point(195, 25);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(156, 47);
            this.btnSuaHV.TabIndex = 1;
            this.btnSuaHV.Text = "Sửa";
            this.btnSuaHV.UseVisualStyleBackColor = true;
            this.btnSuaHV.Click += new System.EventHandler(this.btnSuaHV_Click);
            // 
            // btnThemHV
            // 
            this.btnThemHV.Location = new System.Drawing.Point(19, 25);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(156, 47);
            this.btnThemHV.TabIndex = 0;
            this.btnThemHV.Text = "Thêm";
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMemberID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.nbMoney);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAccountName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 160);
            this.panel2.TabIndex = 7;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(343, 12);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(168, 30);
            this.txtMemberID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã hội viên";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ALLOW",
            "BANNED"});
            this.cbStatus.Location = new System.Drawing.Point(533, 114);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(156, 33);
            this.cbStatus.TabIndex = 9;
            // 
            // nbMoney
            // 
            this.nbMoney.Location = new System.Drawing.Point(533, 61);
            this.nbMoney.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nbMoney.Name = "nbMoney";
            this.nbMoney.Size = new System.Drawing.Size(156, 30);
            this.nbMoney.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền hiện tại";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(159, 57);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(169, 30);
            this.txtAccountName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 59);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý hội viên";
            // 
            // dtgvMember
            // 
            this.dtgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMember.Location = new System.Drawing.Point(31, 253);
            this.dtgvMember.Name = "dtgvMember";
            this.dtgvMember.RowHeadersWidth = 51;
            this.dtgvMember.RowTemplate.Height = 24;
            this.dtgvMember.Size = new System.Drawing.Size(739, 192);
            this.dtgvMember.TabIndex = 9;
            this.dtgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMember_CellContentClick);
            // 
            // MemberAdminControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtgvMember);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemberAdminControl";
            this.Size = new System.Drawing.Size(1025, 599);
            this.Load += new System.EventHandler(this.MemberAdminControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMoney)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLuuHV;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nbMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvMember;
    }
}
