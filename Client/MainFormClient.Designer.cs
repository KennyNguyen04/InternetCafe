namespace Client
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.txtUseTimeFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemainingMoney = new System.Windows.Forms.TextBox();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.txtCurrentMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.chat = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.pnlCharge = new System.Windows.Forms.Panel();
            this.addMoney = new System.Windows.Forms.PictureBox();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.changePass = new System.Windows.Forms.PictureBox();
            this.timerProgram = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grbUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chat)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            this.pnlCharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMoney)).BeginInit();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.txtUseTimeFee);
            this.grbUser.Controls.Add(this.label5);
            this.grbUser.Controls.Add(this.txtRemainingMoney);
            this.grbUser.Controls.Add(this.txtUsedTime);
            this.grbUser.Controls.Add(this.txtCurrentMoney);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.label1);
            this.grbUser.Location = new System.Drawing.Point(12, 98);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(418, 294);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Username";
            this.grbUser.Enter += new System.EventHandler(this.grbUser_Enter);
            // 
            // txtUseTimeFee
            // 
            this.txtUseTimeFee.Enabled = false;
            this.txtUseTimeFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseTimeFee.Location = new System.Drawing.Point(206, 138);
            this.txtUseTimeFee.Name = "txtUseTimeFee";
            this.txtUseTimeFee.Size = new System.Drawing.Size(199, 30);
            this.txtUseTimeFee.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chi phí giờ chơi";
            // 
            // txtRemainingMoney
            // 
            this.txtRemainingMoney.Enabled = false;
            this.txtRemainingMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingMoney.Location = new System.Drawing.Point(206, 188);
            this.txtRemainingMoney.Name = "txtRemainingMoney";
            this.txtRemainingMoney.Size = new System.Drawing.Size(199, 30);
            this.txtRemainingMoney.TabIndex = 5;
            this.txtRemainingMoney.TextChanged += new System.EventHandler(this.txtRemainingMoney_TextChanged);
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.Enabled = false;
            this.txtUsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsedTime.Location = new System.Drawing.Point(206, 88);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.Size = new System.Drawing.Size(199, 30);
            this.txtUsedTime.TabIndex = 4;
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Enabled = false;
            this.txtCurrentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentMoney.Location = new System.Drawing.Point(206, 38);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.Size = new System.Drawing.Size(199, 30);
            this.txtCurrentMoney.TabIndex = 3;
            this.txtCurrentMoney.TextChanged += new System.EventHandler(this.txtCurrentMoney_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền còn lại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 78);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "TRANG CHỦ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlChat
            // 
            this.pnlChat.Controls.Add(this.chat);
            this.pnlChat.Location = new System.Drawing.Point(12, 398);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(75, 75);
            this.pnlChat.TabIndex = 2;
            // 
            // chat
            // 
            this.chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chat.Image = global::Client.Properties.Resources.chat;
            this.chat.Location = new System.Drawing.Point(0, 0);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(75, 75);
            this.chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chat.TabIndex = 0;
            this.chat.TabStop = false;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.menu);
            this.pnlMenu.Location = new System.Drawing.Point(304, 398);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(75, 75);
            this.pnlMenu.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Image = global::Client.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(75, 75);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.Logout);
            this.pnlLogout.Location = new System.Drawing.Point(231, 506);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(75, 75);
            this.pnlLogout.TabIndex = 4;
            this.pnlLogout.Click += new System.EventHandler(this.pnlLogout_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logout.Image = global::Client.Properties.Resources.logout;
            this.Logout.Location = new System.Drawing.Point(0, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 75);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 0;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pnlCharge
            // 
            this.pnlCharge.Controls.Add(this.addMoney);
            this.pnlCharge.Location = new System.Drawing.Point(158, 398);
            this.pnlCharge.Name = "pnlCharge";
            this.pnlCharge.Size = new System.Drawing.Size(75, 75);
            this.pnlCharge.TabIndex = 4;
            // 
            // addMoney
            // 
            this.addMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMoney.Image = global::Client.Properties.Resources.money_bags;
            this.addMoney.Location = new System.Drawing.Point(0, 0);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(75, 75);
            this.addMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addMoney.TabIndex = 0;
            this.addMoney.TabStop = false;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.changePass);
            this.pnlAccount.Location = new System.Drawing.Point(85, 506);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(75, 75);
            this.pnlAccount.TabIndex = 5;
            // 
            // changePass
            // 
            this.changePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePass.Image = global::Client.Properties.Resources.changePass;
            this.changePass.Location = new System.Drawing.Point(0, 0);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(75, 75);
            this.changePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changePass.TabIndex = 0;
            this.changePass.TabStop = false;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // timerProgram
            // 
            this.timerProgram.Tick += new System.EventHandler(this.timerProgram_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox5.Image = global::Client.Properties.Resources.login_background;
            this.pictureBox5.Location = new System.Drawing.Point(0, 600);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(442, 218);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 818);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlCharge);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnlLogout);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "MainFormClient";
            this.Load += new System.EventHandler(this.MainFormClient_Load);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chat)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.pnlLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            this.pnlCharge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMoney)).EndInit();
            this.pnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsedTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.PictureBox chat;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtUseTimeFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCharge;
        private System.Windows.Forms.PictureBox addMoney;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.PictureBox changePass;
        private System.Windows.Forms.Timer timerProgram;
        private System.Windows.Forms.TextBox txtRemainingMoney;
        private System.Windows.Forms.TextBox txtCurrentMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}