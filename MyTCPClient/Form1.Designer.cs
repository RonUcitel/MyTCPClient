namespace MyTCPClient
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
            this.IPText.Location = new System.Drawing.Point(78, 3);
            this.IPText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(124, 20);
            this.IPText.TabIndex = 0;
            // 
            // Startb
            // 
            this.Startb.Location = new System.Drawing.Point(63, 99);
            this.Startb.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Startb.Name = "Startb";
            this.Startb.Size = new System.Drawing.Size(166, 57);
            this.Startb.TabIndex = 1;
            this.Startb.Text = "Start";
            this.Startb.UseVisualStyleBackColor = true;
            this.Startb.Click += new System.EventHandler(this.Startb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name:";
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(78, 37);
            this.PortText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(124, 20);
            this.PortText.TabIndex = 3;
            this.PortText.Text = "13000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server\'s Port: ";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(78, 72);
            this.NameText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(124, 20);
            this.NameText.TabIndex = 5;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Startb);
            this.Controls.Add(this.IPText);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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

