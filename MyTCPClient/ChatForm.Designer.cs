﻿namespace MyTCPClient
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
            this.Dtb = new System.Windows.Forms.RichTextBox();
            this.Mtb = new System.Windows.Forms.TextBox();
            this.Sendb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dtb
            // 
            this.Dtb.Location = new System.Drawing.Point(12, 12);
            this.Dtb.Name = "Dtb";
            this.Dtb.Size = new System.Drawing.Size(776, 382);
            this.Dtb.TabIndex = 0;
            this.Dtb.Text = "";
            // 
            // Mtb
            // 
            this.Mtb.Location = new System.Drawing.Point(12, 400);
            this.Mtb.Name = "Mtb";
            this.Mtb.Size = new System.Drawing.Size(683, 38);
            this.Mtb.TabIndex = 1;
            // 
            // Sendb
            // 
            this.Sendb.Location = new System.Drawing.Point(695, 400);
            this.Sendb.Name = "Sendb";
            this.Sendb.Size = new System.Drawing.Size(93, 38);
            this.Sendb.TabIndex = 2;
            this.Sendb.Text = "Send";
            this.Sendb.UseVisualStyleBackColor = true;
            this.Sendb.Click += new System.EventHandler(this.Sendb_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendb);
            this.Controls.Add(this.Mtb);
            this.Controls.Add(this.Dtb);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Dtb;
        private System.Windows.Forms.TextBox Mtb;
        private System.Windows.Forms.Button Sendb;
    }
}