namespace Server.GUI
{
    partial class ClientDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetailForm));
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblUsedTime = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(0, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(367, 56);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "MAY1";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(223, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hội viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền:";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(223, 130);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(87, 20);
            this.lblTotalMoney.TabIndex = 5;
            this.lblTotalMoney.Text = "totalMoney";
            // 
            // lblUsedTime
            // 
            this.lblUsedTime.AutoSize = true;
            this.lblUsedTime.Location = new System.Drawing.Point(223, 176);
            this.lblUsedTime.Name = "lblUsedTime";
            this.lblUsedTime.Size = new System.Drawing.Size(85, 20);
            this.lblUsedTime.TabIndex = 6;
            this.lblUsedTime.Text = "Used Time";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(32, 278);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(119, 41);
            this.btnAddMoney.TabIndex = 7;
            this.btnAddMoney.Text = "Nạp tiền";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 41);
            this.btnClose.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 56);
            this.panel1.TabIndex = 10;
            // 
            // ClientDetailForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(367, 351);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.lblUsedTime);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClientDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblUsedTime;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}