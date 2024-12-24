namespace Server.GUI
{
    partial class MenuControl
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lsvProduct
            // 
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.GridLines = true;
            this.lsvProduct.HideSelection = false;
            this.lsvProduct.Location = new System.Drawing.Point(4, 6);
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(710, 436);
            this.lsvProduct.TabIndex = 4;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.SelectedIndexChanged += new System.EventHandler(this.lsvProduct_SelectedIndexChanged);
            // 
            // MenuControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsvProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(717, 497);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lsvProduct;
    }
}
