namespace DBapplication
{
    partial class ChangePassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_Password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBapplication.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.Location = new System.Drawing.Point(29, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(118, 56);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(211, 20);
            this.emailBox.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox2.Location = new System.Drawing.Point(29, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(118, 90);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(211, 20);
            this.passwordBox.TabIndex = 10;
            // 
            // NewPasswordbox
            // 
            this.NewPasswordbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.NewPasswordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.NewPasswordbox.ForeColor = System.Drawing.Color.White;
            this.NewPasswordbox.Location = new System.Drawing.Point(118, 129);
            this.NewPasswordbox.Name = "NewPasswordbox";
            this.NewPasswordbox.PasswordChar = '*';
            this.NewPasswordbox.Size = new System.Drawing.Size(211, 20);
            this.NewPasswordbox.TabIndex = 12;
            // 
            // ConfirmPasswordbox
            // 
            this.ConfirmPasswordbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ConfirmPasswordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ConfirmPasswordbox.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordbox.Location = new System.Drawing.Point(118, 163);
            this.ConfirmPasswordbox.Name = "ConfirmPasswordbox";
            this.ConfirmPasswordbox.PasswordChar = '*';
            this.ConfirmPasswordbox.Size = new System.Drawing.Size(211, 20);
            this.ConfirmPasswordbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = " New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirm Password";
            // 
            // Change_Password
            // 
            this.Change_Password.AutoSize = true;
            this.Change_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.Change_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Change_Password.Location = new System.Drawing.Point(211, 202);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(118, 32);
            this.Change_Password.TabIndex = 18;
            this.Change_Password.Text = " Change Password";
            this.Change_Password.UseVisualStyleBackColor = true;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(340, 244);
            this.Controls.Add(this.Change_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPasswordbox);
            this.Controls.Add(this.NewPasswordbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePassword";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox NewPasswordbox;
        private System.Windows.Forms.TextBox ConfirmPasswordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change_Password;
    }
}