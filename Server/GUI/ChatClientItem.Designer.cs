namespace Server.GUI
{
    partial class ChatClientItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClientItem));
            this.pnlClient = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlClient.Controls.Add(this.pictureBox1);
            this.pnlClient.Controls.Add(this.lblUserName);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(233, 48);
            this.pnlClient.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(233, 48);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ChatClientItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlClient);
            this.Name = "ChatClientItem";
            this.Size = new System.Drawing.Size(233, 48);
            this.pnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
