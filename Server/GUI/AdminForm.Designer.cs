namespace Server.GUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.PictureBox();
            this.adminPage = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home Page";
            // 
            // homePage
            // 
            this.homePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePage.Image = global::Server.Properties.Resources.home_page__1_;
            this.homePage.Location = new System.Drawing.Point(339, 108);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(153, 151);
            this.homePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePage.TabIndex = 1;
            this.homePage.TabStop = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // adminPage
            // 
            this.adminPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminPage.Image = global::Server.Properties.Resources.dashboard;
            this.adminPage.Location = new System.Drawing.Point(71, 108);
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(153, 151);
            this.adminPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPage.TabIndex = 0;
            this.adminPage.TabStop = false;
            this.adminPage.Click += new System.EventHandler(this.adminPage_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(523, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 31);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(568, 379);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.adminPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox adminPage;
        private System.Windows.Forms.PictureBox homePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
    }
}