namespace Client
{
    partial class ProductItem
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.ptbProductImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ptbProductImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 221);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.lblProductPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 41);
            this.panel3.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(0, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(183, 41);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "12.000";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductPrice.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 33);
            this.panel2.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(0, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(183, 33);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Mì xào trứng";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Click += new System.EventHandler(this.panel1_Click);
            // 
            // ptbProductImg
            // 
            this.ptbProductImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbProductImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbProductImg.Location = new System.Drawing.Point(32, 41);
            this.ptbProductImg.Name = "ptbProductImg";
            this.ptbProductImg.Size = new System.Drawing.Size(120, 120);
            this.ptbProductImg.TabIndex = 0;
            this.ptbProductImg.TabStop = false;
            this.ptbProductImg.Click += new System.EventHandler(this.panel1_Click);
            // 
            // ProductItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(183, 221);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox ptbProductImg;
    }
}
