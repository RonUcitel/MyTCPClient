namespace MyTCPClient
{
    partial class ChatForm
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
            this.Mtb = new System.Windows.Forms.TextBox();
            this.Sendb = new System.Windows.Forms.Button();
            this.Dlb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Mtb
            // 
            this.Mtb.Location = new System.Drawing.Point(12, 478);
            this.Mtb.Name = "Mtb";
            this.Mtb.Size = new System.Drawing.Size(917, 44);
            this.Mtb.TabIndex = 1;
            this.Mtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mtb_KeyDown);
            // 
            // Sendb
            // 
            this.Sendb.Location = new System.Drawing.Point(935, 478);
            this.Sendb.Name = "Sendb";
            this.Sendb.Size = new System.Drawing.Size(155, 44);
            this.Sendb.TabIndex = 2;
            this.Sendb.Text = "Send";
            this.Sendb.UseVisualStyleBackColor = true;
            this.Sendb.Click += new System.EventHandler(this.Sendb_Click);
            // 
            // Dlb
            // 
            this.Dlb.FormattingEnabled = true;
            this.Dlb.ItemHeight = 37;
            this.Dlb.Location = new System.Drawing.Point(12, 14);
            this.Dlb.Name = "Dlb";
            this.Dlb.Size = new System.Drawing.Size(1078, 448);
            this.Dlb.TabIndex = 3;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 538);
            this.Controls.Add(this.Dlb);
            this.Controls.Add(this.Sendb);
            this.Controls.Add(this.Mtb);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Mtb;
        private System.Windows.Forms.Button Sendb;
        private System.Windows.Forms.ListBox Dlb;
    }
}