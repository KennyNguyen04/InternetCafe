namespace Server.GUI
{
    partial class MemberChatControl
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
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvMessage
            // 
            this.lsvMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.GridLines = true;
            this.lsvMessage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(4, 55);
            this.lsvMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(712, 298);
            this.lsvMessage.TabIndex = 0;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.Details;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(4, 361);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(621, 56);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(632, 362);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 55);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(0, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(720, 40);
            this.lblMemberName.TabIndex = 3;
            this.lblMemberName.Text = "membername";
            this.lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberChatControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lsvMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberChatControl";
            this.Size = new System.Drawing.Size(720, 429);
            this.Load += new System.EventHandler(this.MemberChatControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMemberName;
    }
}
