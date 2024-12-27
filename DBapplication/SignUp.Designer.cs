namespace DBapplication
{
    partial class SignUp
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
            this.finishBtn = new System.Windows.Forms.Button();
            this.Normal_User = new System.Windows.Forms.RadioButton();
            this.Organizer = new System.Windows.Forms.RadioButton();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.specBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.specCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finishBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.finishBtn.ForeColor = System.Drawing.Color.Transparent;
            this.finishBtn.Location = new System.Drawing.Point(247, 476);
            this.finishBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(172, 69);
            this.finishBtn.TabIndex = 0;
            this.finishBtn.Text = "Create Account";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // Normal_User
            // 
            this.Normal_User.AutoSize = true;
            this.Normal_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Normal_User.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal_User.ForeColor = System.Drawing.Color.White;
            this.Normal_User.Location = new System.Drawing.Point(140, 94);
            this.Normal_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Normal_User.Name = "Normal_User";
            this.Normal_User.Size = new System.Drawing.Size(192, 40);
            this.Normal_User.TabIndex = 14;
            this.Normal_User.TabStop = true;
            this.Normal_User.Text = "Normal User";
            this.Normal_User.UseVisualStyleBackColor = true;
            this.Normal_User.CheckedChanged += new System.EventHandler(this.Normal_User_CheckedChanged);
            // 
            // Organizer
            // 
            this.Organizer.AutoSize = true;
            this.Organizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Organizer.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organizer.ForeColor = System.Drawing.Color.White;
            this.Organizer.Location = new System.Drawing.Point(471, 94);
            this.Organizer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Organizer.Name = "Organizer";
            this.Organizer.Size = new System.Drawing.Size(159, 40);
            this.Organizer.TabIndex = 15;
            this.Organizer.TabStop = true;
            this.Organizer.Text = "Organizer";
            this.Organizer.UseVisualStyleBackColor = true;
            this.Organizer.CheckedChanged += new System.EventHandler(this.Organizer_CheckedChanged);
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel32.Controls.Add(this.label3);
            this.panel32.Controls.Add(this.Organizer);
            this.panel32.Controls.Add(this.Normal_User);
            this.panel32.Location = new System.Drawing.Point(-12, -6);
            this.panel32.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(725, 137);
            this.panel32.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(24, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "What kind of user is signing up?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__7_;
            this.pictureBox4.Location = new System.Drawing.Point(-11, 219);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(119, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // numberBox
            // 
            this.numberBox.BackColor = System.Drawing.Color.White;
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.numberBox.ForeColor = System.Drawing.Color.Gray;
            this.numberBox.Location = new System.Drawing.Point(92, 274);
            this.numberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(316, 24);
            this.numberBox.TabIndex = 9;
            this.numberBox.Text = "Phone Number";
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            this.numberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberBox_KeyPress);
            // 
            // lnameBox
            // 
            this.lnameBox.BackColor = System.Drawing.Color.White;
            this.lnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.lnameBox.ForeColor = System.Drawing.Color.Gray;
            this.lnameBox.Location = new System.Drawing.Point(247, 234);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(161, 24);
            this.lnameBox.TabIndex = 5;
            this.lnameBox.Text = "Last Name";
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.passBox.ForeColor = System.Drawing.Color.Gray;
            this.passBox.Location = new System.Drawing.Point(92, 375);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(316, 24);
            this.passBox.TabIndex = 2;
            this.passBox.Text = "Password";
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // fnameBox
            // 
            this.fnameBox.BackColor = System.Drawing.Color.White;
            this.fnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.fnameBox.ForeColor = System.Drawing.Color.Gray;
            this.fnameBox.Location = new System.Drawing.Point(92, 234);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(147, 24);
            this.fnameBox.TabIndex = 6;
            this.fnameBox.Text = "First Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox2.Location = new System.Drawing.Point(37, 375);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.White;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.emailBox.ForeColor = System.Drawing.Color.Gray;
            this.emailBox.Location = new System.Drawing.Point(92, 335);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(316, 24);
            this.emailBox.TabIndex = 1;
            this.emailBox.Text = "E-Mail";
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // specBox
            // 
            this.specBox.BackColor = System.Drawing.Color.Silver;
            this.specBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specBox.ForeColor = System.Drawing.Color.Black;
            this.specBox.Location = new System.Drawing.Point(447, 322);
            this.specBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(199, 21);
            this.specBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBapplication.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.Location = new System.Drawing.Point(40, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // specCombo
            // 
            this.specCombo.BackColor = System.Drawing.Color.White;
            this.specCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specCombo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specCombo.ForeColor = System.Drawing.Color.Gray;
            this.specCombo.FormattingEnabled = true;
            this.specCombo.Items.AddRange(new object[] {
            "Charity Events",
            "Concerts",
            "Conferences",
            "Festivals",
            "Galas",
            "Parties",
            "Weddings",
            "Workshops",
            "Other (Enter Manually)"});
            this.specCombo.Location = new System.Drawing.Point(447, 281);
            this.specCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.specCombo.Name = "specCombo";
            this.specCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.specCombo.Size = new System.Drawing.Size(197, 29);
            this.specCombo.TabIndex = 13;
            this.specCombo.Text = "Specialization";
            this.specCombo.SelectedIndexChanged += new System.EventHandler(this.specCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(455, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "(For Organizers Only)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(665, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specCombo);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.RadioButton Normal_User;
        private System.Windows.Forms.RadioButton Organizer;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox specBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox specCombo;
        private System.Windows.Forms.Label label1;
    }
}