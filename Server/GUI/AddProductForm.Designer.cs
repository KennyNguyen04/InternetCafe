namespace Server.GUI
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnPickImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.txtPriceSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(19, 350);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(190, 22);
            this.txtFilePath.TabIndex = 50;
            // 
            // btnPickImage
            // 
            this.btnPickImage.Location = new System.Drawing.Point(26, 303);
            this.btnPickImage.Name = "btnPickImage";
            this.btnPickImage.Size = new System.Drawing.Size(101, 31);
            this.btnPickImage.TabIndex = 49;
            this.btnPickImage.Text = "Chọn ảnh";
            this.btnPickImage.UseVisualStyleBackColor = true;
            this.btnPickImage.Click += new System.EventHandler(this.btnPickImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 43);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(19, 185);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(190, 24);
            this.cbxType.TabIndex = 47;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(19, 265);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(190, 22);
            this.txtNumber.TabIndex = 46;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(23, 228);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(109, 16);
            this.labelNumber.TabIndex = 45;
            this.labelNumber.Text = "Số lượng hiện có:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(23, 157);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(100, 16);
            this.LabelType.TabIndex = 44;
            this.LabelType.Text = "Loại Sản phẩm:";
            // 
            // txtPriceSP
            // 
            this.txtPriceSP.Location = new System.Drawing.Point(19, 118);
            this.txtPriceSP.Name = "txtPriceSP";
            this.txtPriceSP.Size = new System.Drawing.Size(190, 22);
            this.txtPriceSP.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Giá Sản phẩm:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên Sản phẩm:";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 450);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnPickImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.txtPriceSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Thêm sản phẩm:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnPickImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.TextBox txtPriceSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}