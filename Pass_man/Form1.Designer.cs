namespace Pass_man
{
    partial class MainForm
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
            this.Master_Password = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Site_Button = new System.Windows.Forms.Button();
            this.Username_Button = new System.Windows.Forms.Button();
            this.Password_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Master_Password
            // 
            this.Master_Password.Location = new System.Drawing.Point(12, 29);
            this.Master_Password.Name = "Master_Password";
            this.Master_Password.Size = new System.Drawing.Size(154, 20);
            this.Master_Password.TabIndex = 0;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(12, 10);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(88, 13);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Master Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username/Email:";
            // 
            // Site_Button
            // 
            this.Site_Button.Location = new System.Drawing.Point(418, 130);
            this.Site_Button.Name = "Site_Button";
            this.Site_Button.Size = new System.Drawing.Size(75, 23);
            this.Site_Button.TabIndex = 5;
            this.Site_Button.Text = "button1";
            this.Site_Button.UseVisualStyleBackColor = true;
            this.Site_Button.Click += new System.EventHandler(this.open_site);
            // 
            // Username_Button
            // 
            this.Username_Button.Location = new System.Drawing.Point(418, 185);
            this.Username_Button.Name = "Username_Button";
            this.Username_Button.Size = new System.Drawing.Size(75, 23);
            this.Username_Button.TabIndex = 6;
            this.Username_Button.Text = "button2";
            this.Username_Button.UseVisualStyleBackColor = true;
            this.Username_Button.Click += new System.EventHandler(this.copy_username);
            // 
            // Password_Button
            // 
            this.Password_Button.Location = new System.Drawing.Point(418, 240);
            this.Password_Button.Name = "Password_Button";
            this.Password_Button.Size = new System.Drawing.Size(75, 23);
            this.Password_Button.TabIndex = 7;
            this.Password_Button.Text = "button3";
            this.Password_Button.UseVisualStyleBackColor = true;
            this.Password_Button.Click += new System.EventHandler(this.copy_password);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password_Button);
            this.Controls.Add(this.Username_Button);
            this.Controls.Add(this.Site_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Master_Password);
            this.Name = "MainForm";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Master_Password;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Site_Button;
        private System.Windows.Forms.Button Username_Button;
        private System.Windows.Forms.Button Password_Button;
    }
}

