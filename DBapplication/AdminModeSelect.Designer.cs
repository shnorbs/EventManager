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
            this.AdminMode.Location = new System.Drawing.Point(113, 64);
            this.AdminMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminMode.Name = "AdminMode";
            this.AdminMode.Size = new System.Drawing.Size(236, 115);
            this.AdminMode.TabIndex = 0;
            this.AdminMode.Text = "Admin Mode";
            this.AdminMode.UseVisualStyleBackColor = false;
            // 
            // UserMode
            // 
            this.UserMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.UserMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserMode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.UserMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.UserMode.Location = new System.Drawing.Point(157, 53);
            this.UserMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserMode.Name = "UserMode";
            this.UserMode.Size = new System.Drawing.Size(236, 115);
            this.UserMode.TabIndex = 1;
            this.UserMode.Text = "User Mode";
            this.UserMode.UseVisualStyleBackColor = false;
            this.UserMode.Click += new System.EventHandler(this.UserMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.UserMode);
            this.panel1.Location = new System.Drawing.Point(-44, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 321);
            this.panel1.TabIndex = 2;
            // 
            // AdminModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(455, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminMode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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