namespace Client
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.HidePassCurrentPass = new System.Windows.Forms.PictureBox();
            this.ShowPassCurrentPass = new System.Windows.Forms.PictureBox();
            this.HidePassNewPass = new System.Windows.Forms.PictureBox();
            this.ShowPassNewPass = new System.Windows.Forms.PictureBox();
            this.ShowPassConfirm = new System.Windows.Forms.PictureBox();
            this.HidePassConfirm = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassCurrentPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassCurrentPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận mật khẩu mới";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(251, 154);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size = new System.Drawing.Size(201, 30);
            this.txtCurrentPassword.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(251, 198);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(201, 30);
            this.txtNewPassword.TabIndex = 7;
            // 
            // TxtConfirmNewPass
            // 
            this.TxtConfirmNewPass.Location = new System.Drawing.Point(251, 242);
            this.TxtConfirmNewPass.Name = "TxtConfirmNewPass";
            this.TxtConfirmNewPass.PasswordChar = '●';
            this.TxtConfirmNewPass.Size = new System.Drawing.Size(201, 30);
            this.TxtConfirmNewPass.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(247, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 25);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "username";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Gold;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(112, 301);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(102, 38);
            this.btnChangePass.TabIndex = 10;
            this.btnChangePass.Text = "Xác nhận";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(328, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HidePassCurrentPass
            // 
            this.HidePassCurrentPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePassCurrentPass.Image = ((System.Drawing.Image)(resources.GetObject("HidePassCurrentPass.Image")));
            this.HidePassCurrentPass.Location = new System.Drawing.Point(458, 154);
            this.HidePassCurrentPass.Name = "HidePassCurrentPass";
            this.HidePassCurrentPass.Size = new System.Drawing.Size(26, 26);
            this.HidePassCurrentPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePassCurrentPass.TabIndex = 12;
            this.HidePassCurrentPass.TabStop = false;
            this.HidePassCurrentPass.Visible = false;
            this.HidePassCurrentPass.Click += new System.EventHandler(this.HidePassCurrentPass_Click);
            // 
            // ShowPassCurrentPass
            // 
            this.ShowPassCurrentPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassCurrentPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassCurrentPass.Image")));
            this.ShowPassCurrentPass.Location = new System.Drawing.Point(458, 154);
            this.ShowPassCurrentPass.Name = "ShowPassCurrentPass";
            this.ShowPassCurrentPass.Size = new System.Drawing.Size(26, 26);
            this.ShowPassCurrentPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassCurrentPass.TabIndex = 13;
            this.ShowPassCurrentPass.TabStop = false;
            this.ShowPassCurrentPass.Click += new System.EventHandler(this.ShowPassCurrentPass_Click);
            // 
            // HidePassNewPass
            // 
            this.HidePassNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePassNewPass.Image = ((System.Drawing.Image)(resources.GetObject("HidePassNewPass.Image")));
            this.HidePassNewPass.Location = new System.Drawing.Point(458, 198);
            this.HidePassNewPass.Name = "HidePassNewPass";
            this.HidePassNewPass.Size = new System.Drawing.Size(26, 26);
            this.HidePassNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePassNewPass.TabIndex = 14;
            this.HidePassNewPass.TabStop = false;
            this.HidePassNewPass.Visible = false;
            this.HidePassNewPass.Click += new System.EventHandler(this.HidePassNewPass_Click);
            // 
            // ShowPassNewPass
            // 
            this.ShowPassNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassNewPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassNewPass.Image")));
            this.ShowPassNewPass.Location = new System.Drawing.Point(458, 198);
            this.ShowPassNewPass.Name = "ShowPassNewPass";
            this.ShowPassNewPass.Size = new System.Drawing.Size(26, 26);
            this.ShowPassNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassNewPass.TabIndex = 15;
            this.ShowPassNewPass.TabStop = false;
            this.ShowPassNewPass.Click += new System.EventHandler(this.ShowPassNewPass_Click);
            // 
            // ShowPassConfirm
            // 
            this.ShowPassConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassConfirm.Image")));
            this.ShowPassConfirm.Location = new System.Drawing.Point(458, 242);
            this.ShowPassConfirm.Name = "ShowPassConfirm";
            this.ShowPassConfirm.Size = new System.Drawing.Size(26, 26);
            this.ShowPassConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassConfirm.TabIndex = 16;
            this.ShowPassConfirm.TabStop = false;
            this.ShowPassConfirm.Click += new System.EventHandler(this.ShowPassConfirm_Click);
            // 
            // HidePassConfirm
            // 
            this.HidePassConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePassConfirm.Image = ((System.Drawing.Image)(resources.GetObject("HidePassConfirm.Image")));
            this.HidePassConfirm.Location = new System.Drawing.Point(458, 242);
            this.HidePassConfirm.Name = "HidePassConfirm";
            this.HidePassConfirm.Size = new System.Drawing.Size(26, 26);
            this.HidePassConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePassConfirm.TabIndex = 17;
            this.HidePassConfirm.TabStop = false;
            this.HidePassConfirm.Visible = false;
            this.HidePassConfirm.Click += new System.EventHandler(this.HidePassConfirm_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.btnChangePass;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(547, 369);
            this.ControlBox = false;
            this.Controls.Add(this.HidePassConfirm);
            this.Controls.Add(this.HidePassNewPass);
            this.Controls.Add(this.HidePassCurrentPass);
            this.Controls.Add(this.ShowPassConfirm);
            this.Controls.Add(this.ShowPassNewPass);
            this.Controls.Add(this.ShowPassCurrentPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.TxtConfirmNewPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassCurrentPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassCurrentPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox TxtConfirmNewPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox HidePassCurrentPass;
        private System.Windows.Forms.PictureBox ShowPassCurrentPass;
        private System.Windows.Forms.PictureBox HidePassNewPass;
        private System.Windows.Forms.PictureBox ShowPassNewPass;
        private System.Windows.Forms.PictureBox ShowPassConfirm;
        private System.Windows.Forms.PictureBox HidePassConfirm;
        private System.Windows.Forms.Timer timer1;
    }
}