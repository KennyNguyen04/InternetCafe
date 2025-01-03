namespace Client
{
    partial class CartItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ptbDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(291, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 73);
            this.panel5.TabIndex = 3;
            // 
            // ptbDelete
            // 
            this.ptbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(15, 14);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(54, 45);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDelete.TabIndex = 0;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudQuantity);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(213, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 73);
            this.panel4.TabIndex = 2;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(12, 24);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 24);
            this.nudQuantity.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(73, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 73);
            this.panel3.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 73);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 73);
            this.panel2.TabIndex = 0;
            // 
            // ptbImage
            // 
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(73, 73);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(371, 73);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox ptbImage;
    }
}
