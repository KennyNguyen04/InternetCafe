namespace Server.GUI
{
    partial class ProductDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailForm));
            this.btnPickImage = new System.Windows.Forms.Button();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            // btnPickImage
            // 
            this.btnPickImage.Location = new System.Drawing.Point(22, 267);
            this.btnPickImage.Name = "btnPickImage";
            this.btnPickImage.Size = new System.Drawing.Size(103, 30);
            this.btnPickImage.TabIndex = 42;
            this.btnPickImage.Text = "Chọn ảnh";
            this.btnPickImage.UseVisualStyleBackColor = true;
            this.btnPickImage.Click += new System.EventHandler(this.btnPickImage_Click);
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(15, 301);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(190, 22);
            this.txtImageUrl.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 43);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(125, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 43);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 43);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(15, 171);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(190, 24);
            this.cbxType.TabIndex = 37;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(15, 239);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(190, 22);
            this.txtNumber.TabIndex = 36;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(19, 212);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(105, 16);
            this.labelNumber.TabIndex = 35;
            this.labelNumber.Text = "Số lượng còn lại:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(19, 143);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(100, 16);
            this.LabelType.TabIndex = 34;
            this.LabelType.Text = "Loại Sản phẩm:";
            // 
            // txtPriceSP
            // 
            this.txtPriceSP.Location = new System.Drawing.Point(15, 99);
            this.txtPriceSP.Name = "txtPriceSP";
            this.txtPriceSP.Size = new System.Drawing.Size(190, 22);
            this.txtPriceSP.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Giá Sản phẩm:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên Sản phẩm:";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 450);
            this.Controls.Add(this.btnPickImage);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "ProductDetailForm";
            this.Text = "Chi tiết sản phẩm:";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickImage;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
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