﻿namespace DBapplication
{
    partial class Welcome
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
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Change_Password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(147, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 92);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome, \r\nPlease Log-In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(140, 186);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(281, 24);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(140, 252);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(281, 24);
            this.passwordBox.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(302, 315);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(104, 43);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.AutoSize = true;
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.regBtn.Location = new System.Drawing.Point(190, 315);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(104, 43);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Sign Up";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox2.Location = new System.Drawing.Point(52, 245);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBapplication.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.Location = new System.Drawing.Point(52, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(302, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change_Password
            // 
            this.Change_Password.BackColor = System.Drawing.Color.Silver;
            this.Change_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Change_Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change_Password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password.ForeColor = System.Drawing.Color.White;
            this.Change_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_Password.Location = new System.Drawing.Point(190, 362);
            this.Change_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(104, 47);
            this.Change_Password.TabIndex = 10;
            this.Change_Password.Text = "Change Password";
            this.Change_Password.UseVisualStyleBackColor = false;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(524, 477);
            this.Controls.Add(this.Change_Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Change_Password;
    }
}