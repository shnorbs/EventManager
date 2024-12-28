namespace DBapplication
{
    partial class ReportDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportDescriptionBox = new System.Windows.Forms.TextBox();
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminReplyBox = new System.Windows.Forms.TextBox();
            this.BanOrganizerButton = new System.Windows.Forms.Button();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.IgnoreButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Details and Actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(33, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Report Description";
            // 
            // ReportDescriptionBox
            // 
            this.ReportDescriptionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReportDescriptionBox.Location = new System.Drawing.Point(37, 176);
            this.ReportDescriptionBox.Multiline = true;
            this.ReportDescriptionBox.Name = "ReportDescriptionBox";
            this.ReportDescriptionBox.ReadOnly = true;
            this.ReportDescriptionBox.Size = new System.Drawing.Size(545, 66);
            this.ReportDescriptionBox.TabIndex = 4;
            // 
            // EventNameBox
            // 
            this.EventNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EventNameBox.Location = new System.Drawing.Point(37, 83);
            this.EventNameBox.Multiline = true;
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.ReadOnly = true;
            this.EventNameBox.Size = new System.Drawing.Size(545, 39);
            this.EventNameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(33, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Admin Reply";
            // 
            // AdminReplyBox
            // 
            this.AdminReplyBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AdminReplyBox.Location = new System.Drawing.Point(37, 291);
            this.AdminReplyBox.Multiline = true;
            this.AdminReplyBox.Name = "AdminReplyBox";
            this.AdminReplyBox.Size = new System.Drawing.Size(545, 62);
            this.AdminReplyBox.TabIndex = 7;
            // 
            // BanOrganizerButton
            // 
            this.BanOrganizerButton.BackColor = System.Drawing.Color.Red;
            this.BanOrganizerButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BanOrganizerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BanOrganizerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BanOrganizerButton.Location = new System.Drawing.Point(37, 429);
            this.BanOrganizerButton.Name = "BanOrganizerButton";
            this.BanOrganizerButton.Size = new System.Drawing.Size(145, 58);
            this.BanOrganizerButton.TabIndex = 8;
            this.BanOrganizerButton.Text = "Ban Organizer";
            this.BanOrganizerButton.UseVisualStyleBackColor = false;
            this.BanOrganizerButton.Click += new System.EventHandler(this.BanOrganizerButton_Click);
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.BackColor = System.Drawing.Color.Red;
            this.DeleteEventButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteEventButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DeleteEventButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteEventButton.Location = new System.Drawing.Point(235, 429);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(144, 58);
            this.DeleteEventButton.TabIndex = 9;
            this.DeleteEventButton.Text = "Delete Event";
            this.DeleteEventButton.UseVisualStyleBackColor = false;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // IgnoreButton
            // 
            this.IgnoreButton.BackColor = System.Drawing.Color.DimGray;
            this.IgnoreButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.IgnoreButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IgnoreButton.Location = new System.Drawing.Point(431, 429);
            this.IgnoreButton.Name = "IgnoreButton";
            this.IgnoreButton.Size = new System.Drawing.Size(151, 58);
            this.IgnoreButton.TabIndex = 10;
            this.IgnoreButton.Text = "Ignore";
            this.IgnoreButton.UseVisualStyleBackColor = false;
            this.IgnoreButton.Click += new System.EventHandler(this.IgnoreButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(33, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Take Action:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(34, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(560, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "_____________________________________________________________________";
            // 
            // ReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(628, 506);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IgnoreButton);
            this.Controls.Add(this.DeleteEventButton);
            this.Controls.Add(this.BanOrganizerButton);
            this.Controls.Add(this.AdminReplyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventNameBox);
            this.Controls.Add(this.ReportDescriptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportDetails";
            this.Text = "Report Details";
            this.Load += new System.EventHandler(this.ReportDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReportDescriptionBox;
        private System.Windows.Forms.TextBox EventNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminReplyBox;
        private System.Windows.Forms.Button BanOrganizerButton;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.Button IgnoreButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}