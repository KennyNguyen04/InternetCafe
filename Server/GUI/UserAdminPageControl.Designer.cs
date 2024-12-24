namespace Server.GUI
{
    partial class UserAdminPageControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvUsers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGroupUser = new System.Windows.Forms.ComboBox();
            this.btnThemUser = new System.Windows.Forms.Button();
            this.btnSuaUser = new System.Windows.Forms.Button();
            this.btnXoaUser = new System.Windows.Forms.Button();
            this.btnLuuUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbGroupUser);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFullname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 180);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvUsers);
            this.panel3.Location = new System.Drawing.Point(25, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 195);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLuuUser);
            this.panel4.Controls.Add(this.btnXoaUser);
            this.panel4.Controls.Add(this.btnSuaUser);
            this.panel4.Controls.Add(this.btnThemUser);
            this.panel4.Location = new System.Drawing.Point(24, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 104);
            this.panel4.TabIndex = 3;
            // 
            // dtgvUsers
            // 
            this.dtgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsers.Location = new System.Drawing.Point(4, 4);
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.RowHeadersWidth = 51;
            this.dtgvUsers.RowTemplate.Height = 24;
            this.dtgvUsers.Size = new System.Drawing.Size(760, 190);
            this.dtgvUsers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã người dùng";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(386, 13);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(162, 30);
            this.txtUserId.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(194, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 30);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(194, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(194, 138);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(162, 30);
            this.txtFullname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(571, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 30);
            this.txtPhone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(571, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Loại";
            // 
            // cbGroupUser
            // 
            this.cbGroupUser.FormattingEnabled = true;
            this.cbGroupUser.Items.AddRange(new object[] {
            "Manager",
            "Staff"});
            this.cbGroupUser.Location = new System.Drawing.Point(571, 141);
            this.cbGroupUser.Name = "cbGroupUser";
            this.cbGroupUser.Size = new System.Drawing.Size(162, 33);
            this.cbGroupUser.TabIndex = 13;
            this.cbGroupUser.SelectedIndexChanged += new System.EventHandler(this.cbGroupUser_SelectedIndexChanged);
            // 
            // btnThemUser
            // 
            this.btnThemUser.Location = new System.Drawing.Point(24, 11);
            this.btnThemUser.Name = "btnThemUser";
            this.btnThemUser.Size = new System.Drawing.Size(137, 51);
            this.btnThemUser.TabIndex = 0;
            this.btnThemUser.Text = "Thêm";
            this.btnThemUser.UseVisualStyleBackColor = true;
            this.btnThemUser.Click += new System.EventHandler(this.btnThemUser_Click);
            // 
            // btnSuaUser
            // 
            this.btnSuaUser.Location = new System.Drawing.Point(213, 11);
            this.btnSuaUser.Name = "btnSuaUser";
            this.btnSuaUser.Size = new System.Drawing.Size(137, 51);
            this.btnSuaUser.TabIndex = 1;
            this.btnSuaUser.Text = "Sửa";
            this.btnSuaUser.UseVisualStyleBackColor = true;
            this.btnSuaUser.Click += new System.EventHandler(this.btnSuaUser_Click);
            // 
            // btnXoaUser
            // 
            this.btnXoaUser.Location = new System.Drawing.Point(405, 11);
            this.btnXoaUser.Name = "btnXoaUser";
            this.btnXoaUser.Size = new System.Drawing.Size(137, 51);
            this.btnXoaUser.TabIndex = 2;
            this.btnXoaUser.Text = "Xóa";
            this.btnXoaUser.UseVisualStyleBackColor = true;
            this.btnXoaUser.Click += new System.EventHandler(this.btnXoaUser_Click);
            // 
            // btnLuuUser
            // 
            this.btnLuuUser.Location = new System.Drawing.Point(590, 11);
            this.btnLuuUser.Name = "btnLuuUser";
            this.btnLuuUser.Size = new System.Drawing.Size(137, 51);
            this.btnLuuUser.TabIndex = 3;
            this.btnLuuUser.Text = "Lưu";
            this.btnLuuUser.UseVisualStyleBackColor = true;
            this.btnLuuUser.Click += new System.EventHandler(this.btnLuuUser_Click);
            // 
            // UserAdminPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserAdminPageControl";
            this.Size = new System.Drawing.Size(953, 608);
            this.Load += new System.EventHandler(this.UserAdminPageControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGroupUser;
        private System.Windows.Forms.Button btnThemUser;
        private System.Windows.Forms.Button btnLuuUser;
        private System.Windows.Forms.Button btnXoaUser;
        private System.Windows.Forms.Button btnSuaUser;
    }
}
