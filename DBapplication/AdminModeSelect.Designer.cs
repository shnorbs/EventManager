namespace DBapplication
{
    partial class AdminModeSelect
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
            this.AdminMode = new System.Windows.Forms.Button();
            this.UserMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminMode
            // 
            this.AdminMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.AdminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminMode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.AdminMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.AdminMode.Location = new System.Drawing.Point(88, 51);
            this.AdminMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminMode.Name = "AdminMode";
            this.AdminMode.Size = new System.Drawing.Size(184, 92);
            this.AdminMode.TabIndex = 0;
            this.AdminMode.Text = "Admin Mode";
            this.AdminMode.UseVisualStyleBackColor = false;
            this.AdminMode.Click += new System.EventHandler(this.AdminMode_Click);
            // 
            // UserMode
            // 
            this.UserMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.UserMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserMode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.UserMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.UserMode.Location = new System.Drawing.Point(122, 42);
            this.UserMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserMode.Name = "UserMode";
            this.UserMode.Size = new System.Drawing.Size(184, 92);
            this.UserMode.TabIndex = 1;
            this.UserMode.Text = "User Mode";
            this.UserMode.UseVisualStyleBackColor = false;
            this.UserMode.Click += new System.EventHandler(this.UserMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.UserMode);
            this.panel1.Location = new System.Drawing.Point(-34, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 257);
            this.panel1.TabIndex = 2;
            // 
            // AdminModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(354, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminMode);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminModeSelect";
            this.Text = "AdminModeSelect";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminMode;
        private System.Windows.Forms.Button UserMode;
        private System.Windows.Forms.Panel panel1;
    }
}