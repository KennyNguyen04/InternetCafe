namespace Client
{
    partial class AddMoneyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMoneyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptbWaiting = new System.Windows.Forms.PictureBox();
            this.ptbDone = new System.Windows.Forms.PictureBox();
            this.ptbDeny = new System.Windows.Forms.PictureBox();
            this.txtMoney = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "NẠP TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số tiền cần nạp:";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMoney.Location = new System.Drawing.Point(128, 242);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(187, 39);
            this.btnAddMoney.TabIndex = 3;
            this.btnAddMoney.Text = "Xác nhận";
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(339, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptbWaiting
            // 
            this.ptbWaiting.Image = ((System.Drawing.Image)(resources.GetObject("ptbWaiting.Image")));
            this.ptbWaiting.Location = new System.Drawing.Point(178, 159);
            this.ptbWaiting.Name = "ptbWaiting";
            this.ptbWaiting.Size = new System.Drawing.Size(74, 73);
            this.ptbWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbWaiting.TabIndex = 5;
            this.ptbWaiting.TabStop = false;
            this.ptbWaiting.Visible = false;
            // 
            // ptbDone
            // 
            this.ptbDone.Image = ((System.Drawing.Image)(resources.GetObject("ptbDone.Image")));
            this.ptbDone.Location = new System.Drawing.Point(178, 159);
            this.ptbDone.Name = "ptbDone";
            this.ptbDone.Size = new System.Drawing.Size(74, 73);
            this.ptbDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDone.TabIndex = 6;
            this.ptbDone.TabStop = false;
            this.ptbDone.Visible = false;
            // 
            // ptbDeny
            // 
            this.ptbDeny.Image = ((System.Drawing.Image)(resources.GetObject("ptbDeny.Image")));
            this.ptbDeny.Location = new System.Drawing.Point(284, 159);
            this.ptbDeny.Name = "ptbDeny";
            this.ptbDeny.Size = new System.Drawing.Size(74, 73);
            this.ptbDeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDeny.TabIndex = 7;
            this.ptbDeny.TabStop = false;
            this.ptbDeny.Visible = false;
            // 
            // txtMoney
            // 
            this.txtMoney.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMoney.Location = new System.Drawing.Point(277, 110);
            this.txtMoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(120, 35);
            this.txtMoney.TabIndex = 8;
            // 
            // AddMoneyForm
            // 
            this.AcceptButton = this.btnAddMoney;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 337);
            this.ControlBox = false;
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.ptbDeny);
            this.Controls.Add(this.ptbDone);
            this.Controls.Add(this.ptbWaiting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddMoneyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptbWaiting;
        private System.Windows.Forms.PictureBox ptbDone;
        private System.Windows.Forms.PictureBox ptbDeny;
        private System.Windows.Forms.NumericUpDown txtMoney;
    }
}