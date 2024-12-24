namespace Server.GUI
{
    partial class ClientAdminControl
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
            this.btnGroupClient = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cbxGrClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGroupClient
            // 
            this.btnGroupClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGroupClient.Location = new System.Drawing.Point(492, 437);
            this.btnGroupClient.Name = "btnGroupClient";
            this.btnGroupClient.Size = new System.Drawing.Size(204, 38);
            this.btnGroupClient.TabIndex = 29;
            this.btnGroupClient.Text = "Tùy chỉnh GroupClient";
            this.btnGroupClient.UseVisualStyleBackColor = true;
            this.btnGroupClient.Click += new System.EventHandler(this.btnGroupClient_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(511, 121);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(185, 30);
            this.txtStatus.TabIndex = 28;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(169, 121);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(185, 30);
            this.txtClientIP.TabIndex = 27;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(169, 66);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(185, 30);
            this.txtClientName.TabIndex = 26;
            // 
            // cbxGrClient
            // 
            this.cbxGrClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrClient.FormattingEnabled = true;
            this.cbxGrClient.Location = new System.Drawing.Point(510, 66);
            this.cbxGrClient.Name = "cbxGrClient";
            this.cbxGrClient.Size = new System.Drawing.Size(186, 33);
            this.cbxGrClient.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Group Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Client:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "THÔNG TIN CLIENT";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(358, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(126, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 38);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(17, 178);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(679, 244);
            this.dgvClient.TabIndex = 15;
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellContentClick);
            // 
            // ClientAdminControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnGroupClient);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.cbxGrClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientAdminControl";
            this.Size = new System.Drawing.Size(718, 497);
            this.Load += new System.EventHandler(this.ClientAdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGroupClient;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ComboBox cbxGrClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvClient;
    }
}
