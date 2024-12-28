﻿namespace DBapplication
{
    partial class PublicEventDetails
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
            this.eventName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.eventType = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimeLbl = new System.Windows.Forms.Label();
            this.endTimeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.venueName = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.Ticket_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Invites = new System.Windows.Forms.Button();
            this.ViewLink = new System.Windows.Forms.LinkLabel();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.eventName.ForeColor = System.Drawing.Color.White;
            this.eventName.Location = new System.Drawing.Point(13, 14);
            this.eventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventName.Name = "eventName";
            this.eventName.Padding = new System.Windows.Forms.Padding(1);
            this.eventName.Size = new System.Drawing.Size(216, 41);
            this.eventName.TabIndex = 0;
            this.eventName.Text = "Event Name";
            // 
            // description
            // 
            this.description.AutoEllipsis = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Snow;
            this.description.Location = new System.Drawing.Point(2, 196);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(560, 64);
            this.description.TabIndex = 1;
            this.description.Text = "DESCRIPTION";
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // eventType
            // 
            this.eventType.AutoSize = true;
            this.eventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventType.ForeColor = System.Drawing.Color.White;
            this.eventType.Location = new System.Drawing.Point(14, 60);
            this.eventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventType.Name = "eventType";
            this.eventType.Padding = new System.Windows.Forms.Padding(1);
            this.eventType.Size = new System.Drawing.Size(92, 31);
            this.eventType.TabIndex = 2;
            this.eventType.Text = "(Type)";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Snow;
            this.time.Location = new System.Drawing.Point(30, 279);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(81, 31);
            this.time.TabIndex = 3;
            this.time.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(205, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // startTimeLbl
            // 
            this.startTimeLbl.AutoSize = true;
            this.startTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.startTimeLbl.Location = new System.Drawing.Point(98, 279);
            this.startTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLbl.Name = "startTimeLbl";
            this.startTimeLbl.Size = new System.Drawing.Size(128, 31);
            this.startTimeLbl.TabIndex = 6;
            this.startTimeLbl.Text = "00:00:00";
            // 
            // endTimeLbl
            // 
            this.endTimeLbl.AutoSize = true;
            this.endTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.endTimeLbl.Location = new System.Drawing.Point(240, 279);
            this.endTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLbl.Name = "endTimeLbl";
            this.endTimeLbl.Size = new System.Drawing.Size(128, 31);
            this.endTimeLbl.TabIndex = 7;
            this.endTimeLbl.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(34, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "At";
            // 
            // venueName
            // 
            this.venueName.AutoSize = true;
            this.venueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.venueName.Location = new System.Drawing.Point(70, 318);
            this.venueName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.venueName.Name = "venueName";
            this.venueName.Size = new System.Drawing.Size(181, 31);
            this.venueName.TabIndex = 9;
            this.venueName.Text = "Venue Name";
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel32.Controls.Add(this.feedbackBtn);
            this.panel32.Controls.Add(this.reportBtn);
            this.panel32.Controls.Add(this.eventName);
            this.panel32.Controls.Add(this.eventType);
            this.panel32.Location = new System.Drawing.Point(-5, -2);
            this.panel32.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(756, 110);
            this.panel32.TabIndex = 13;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.feedbackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(447, 27);
            this.feedbackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(170, 58);
            this.feedbackBtn.TabIndex = 17;
            this.feedbackBtn.Text = "Give Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__8_;
            this.reportBtn.Location = new System.Drawing.Point(625, 27);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(71, 58);
            this.reportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reportBtn.TabIndex = 15;
            this.reportBtn.TabStop = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(187, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // reminderBtn
            // 
            this.reminderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.reminderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reminderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reminderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderBtn.ForeColor = System.Drawing.Color.White;
            this.reminderBtn.Location = new System.Drawing.Point(544, 378);
            this.reminderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(148, 43);
            this.reminderBtn.TabIndex = 16;
            this.reminderBtn.Text = "Set Reminder";
            this.reminderBtn.UseVisualStyleBackColor = false;
            this.reminderBtn.Click += new System.EventHandler(this.reminderBtn_Click);
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.BurlyWood;
            this.Buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.ForeColor = System.Drawing.SystemColors.Control;
            this.Buy.Location = new System.Drawing.Point(544, 326);
            this.Buy.Margin = new System.Windows.Forms.Padding(2);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(148, 46);
            this.Buy.TabIndex = 17;
            this.Buy.Text = "Buy Tickets";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Ticket_Type
            // 
            this.Ticket_Type.FormattingEnabled = true;
            this.Ticket_Type.Location = new System.Drawing.Point(567, 241);
            this.Ticket_Type.Margin = new System.Windows.Forms.Padding(2);
            this.Ticket_Type.Name = "Ticket_Type";
            this.Ticket_Type.Size = new System.Drawing.Size(107, 24);
            this.Ticket_Type.TabIndex = 18;
            this.Ticket_Type.SelectedIndexChanged += new System.EventHandler(this.Ticket_Type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(576, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buy ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(623, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.ForeColor = System.Drawing.Color.BurlyWood;
            this.Number.Location = new System.Drawing.Point(602, 270);
            this.Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(16, 17);
            this.Number.TabIndex = 22;
            this.Number.Text = "0";
            this.Number.Click += new System.EventHandler(this.Number_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(620, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tickets";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Invites
            // 
            this.Invites.BackColor = System.Drawing.Color.MidnightBlue;
            this.Invites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Invites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invites.ForeColor = System.Drawing.SystemColors.Control;
            this.Invites.Location = new System.Drawing.Point(15, 378);
            this.Invites.Margin = new System.Windows.Forms.Padding(2);
            this.Invites.Name = "Invites";
            this.Invites.Size = new System.Drawing.Size(148, 43);
            this.Invites.TabIndex = 24;
            this.Invites.Text = "Add Invites";
            this.Invites.UseVisualStyleBackColor = false;
            this.Invites.Click += new System.EventHandler(this.Invites_Click);
            // 
            // ViewLink
            // 
            this.ViewLink.AutoSize = true;
            this.ViewLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.ViewLink.Location = new System.Drawing.Point(477, 112);
            this.ViewLink.Name = "ViewLink";
            this.ViewLink.Size = new System.Drawing.Size(113, 17);
            this.ViewLink.TabIndex = 25;
            this.ViewLink.TabStop = true;
            this.ViewLink.Text = "View All Feedback";
            this.ViewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewLink_LinkClicked);
            // 
            // PublicEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(707, 434);
            this.Controls.Add(this.ViewLink);
            this.Controls.Add(this.Invites);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ticket_Type);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.reminderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.venueName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTimeLbl);
            this.Controls.Add(this.startTimeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.description);
            this.Controls.Add(this.panel32);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PublicEventDetails";
            this.Text = "Event Details";
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label eventType;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startTimeLbl;
        private System.Windows.Forms.Label endTimeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label venueName;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox reportBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button reminderBtn;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.ComboBox Ticket_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Invites;
        private System.Windows.Forms.LinkLabel ViewLink;
    }
}