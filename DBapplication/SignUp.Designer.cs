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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.specBox = new System.Windows.Forms.TextBox();
            this.specCombo = new System.Windows.Forms.ComboBox();
            this.Normal_User = new System.Windows.Forms.RadioButton();
            this.Organizer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(202, 320);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(118, 31);
            this.finishBtn.TabIndex = 0;
            this.finishBtn.Text = "Create Account";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(83, 116);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(179, 20);
            this.emailBox.TabIndex = 1;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(83, 142);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(179, 20);
            this.passBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(382, 142);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(179, 20);
            this.lnameBox.TabIndex = 5;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(382, 116);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(179, 20);
            this.fnameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(382, 168);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(179, 20);
            this.numberBox.TabIndex = 9;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            this.numberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Specialization";
            // 
            // specBox
            // 
            this.specBox.Location = new System.Drawing.Point(474, 59);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(102, 20);
            this.specBox.TabIndex = 10;
            // 
            // specCombo
            // 
            this.specCombo.FormattingEnabled = true;
            this.specCombo.Items.AddRange(new object[] {
            "Weddings",
            "Conferences",
            "Concerts",
            "Parties",
            "Charity Events",
            "Galas",
            "Workshops",
            "Festivals",
            "Other"});
            this.specCombo.Location = new System.Drawing.Point(474, 32);
            this.specCombo.Name = "specCombo";
            this.specCombo.Size = new System.Drawing.Size(102, 21);
            this.specCombo.TabIndex = 13;
            this.specCombo.SelectedIndexChanged += new System.EventHandler(this.specCombo_SelectedIndexChanged);
            // 
            // Normal_User
            // 
            this.Normal_User.AutoSize = true;
            this.Normal_User.Location = new System.Drawing.Point(179, 37);
            this.Normal_User.Name = "Normal_User";
            this.Normal_User.Size = new System.Drawing.Size(83, 17);
            this.Normal_User.TabIndex = 14;
            this.Normal_User.TabStop = true;
            this.Normal_User.Text = "Normal User";
            this.Normal_User.UseVisualStyleBackColor = true;
            // 
            // Organizer
            // 
            this.Organizer.AutoSize = true;
            this.Organizer.Location = new System.Drawing.Point(279, 37);
            this.Organizer.Name = "Organizer";
            this.Organizer.Size = new System.Drawing.Size(70, 17);
            this.Organizer.TabIndex = 15;
            this.Organizer.TabStop = true;
            this.Organizer.Text = "Organizer";
            this.Organizer.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 372);
            this.Controls.Add(this.Organizer);
            this.Controls.Add(this.Normal_User);
            this.Controls.Add(this.specCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.finishBtn);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox specBox;
        private System.Windows.Forms.ComboBox specCombo;
        private System.Windows.Forms.RadioButton Normal_User;
        private System.Windows.Forms.RadioButton Organizer;
    }
}