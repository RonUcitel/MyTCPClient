﻿namespace MyTCPClient
{
    partial class StartUpForm
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
            this.IPText = new System.Windows.Forms.TextBox();
            this.Startb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(209, 6);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(323, 38);
            this.IPText.TabIndex = 0;
            // 
            // Startb
            // 
            this.Startb.Location = new System.Drawing.Point(168, 235);
            this.Startb.Name = "Startb";
            this.Startb.Size = new System.Drawing.Size(444, 137);
            this.Startb.TabIndex = 1;
            this.Startb.Text = "Start";
            this.Startb.UseVisualStyleBackColor = true;
            this.Startb.Click += new System.EventHandler(this.Startb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name:";
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(209, 88);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(323, 38);
            this.PortText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server\'s Port: ";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(209, 171);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(323, 38);
            this.NameText.TabIndex = 5;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Startb);
            this.Controls.Add(this.IPText);
            this.Name = "StartUpForm";
            this.Text = "Start!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Button Startb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
    }
}

