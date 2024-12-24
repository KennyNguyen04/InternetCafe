namespace Server.GUI
{
    partial class ChatControl
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
            this.components = new System.ComponentModel.Container();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMemberContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.pnlMemberContainer);
            this.pnlClient.Controls.Add(this.label1);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(245, 442);
            this.pnlClient.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(245, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(720, 442);
            this.pnlContainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hội viên đang hoạt động";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemberContainer
            // 
            this.pnlMemberContainer.AutoScroll = true;
            this.pnlMemberContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMemberContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMemberContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMemberContainer.Location = new System.Drawing.Point(0, 56);
            this.pnlMemberContainer.Name = "pnlMemberContainer";
            this.pnlMemberContainer.Size = new System.Drawing.Size(245, 386);
            this.pnlMemberContainer.TabIndex = 1;
            this.pnlMemberContainer.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChatControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(965, 442);
            this.Load += new System.EventHandler(this.ChatControl_Load);
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlMemberContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
