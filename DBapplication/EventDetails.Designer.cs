namespace DBapplication
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
            this.label3 = new System.Windows.Forms.Label();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.PictureBox();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold);
            this.eventName.ForeColor = System.Drawing.Color.White;
            this.eventName.Location = new System.Drawing.Point(11, 11);
            this.eventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventName.Name = "eventName";
            this.eventName.Padding = new System.Windows.Forms.Padding(1);
            this.eventName.Size = new System.Drawing.Size(168, 38);
            this.eventName.TabIndex = 0;
            this.eventName.Text = "Event Name";
            // 
            // description
            // 
            this.description.AutoEllipsis = true;
            this.description.Font = new System.Drawing.Font("Segoe UI Variable Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Snow;
            this.description.Location = new System.Drawing.Point(8, 158);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(517, 52);
            this.description.TabIndex = 1;
            this.description.Text = "DESCRIPTION";
            // 
            // eventType
            // 
            this.eventType.AutoSize = true;
            this.eventType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventType.ForeColor = System.Drawing.Color.White;
            this.eventType.Location = new System.Drawing.Point(12, 49);
            this.eventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventType.Name = "eventType";
            this.eventType.Padding = new System.Windows.Forms.Padding(1);
            this.eventType.Size = new System.Drawing.Size(66, 28);
            this.eventType.TabIndex = 2;
            this.eventType.Text = "(Type)";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Snow;
            this.time.Location = new System.Drawing.Point(26, 227);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(65, 30);
            this.time.TabIndex = 3;
            this.time.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(176, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // startTimeLbl
            // 
            this.startTimeLbl.AutoSize = true;
            this.startTimeLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.startTimeLbl.Location = new System.Drawing.Point(84, 227);
            this.startTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLbl.Name = "startTimeLbl";
            this.startTimeLbl.Size = new System.Drawing.Size(95, 30);
            this.startTimeLbl.TabIndex = 6;
            this.startTimeLbl.Text = "00:00:00";
            // 
            // endTimeLbl
            // 
            this.endTimeLbl.AutoSize = true;
            this.endTimeLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.endTimeLbl.Location = new System.Drawing.Point(206, 227);
            this.endTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLbl.Name = "endTimeLbl";
            this.endTimeLbl.Size = new System.Drawing.Size(95, 30);
            this.endTimeLbl.TabIndex = 7;
            this.endTimeLbl.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(29, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "At";
            // 
            // venueName
            // 
            this.venueName.AutoSize = true;
            this.venueName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.venueName.Location = new System.Drawing.Point(60, 258);
            this.venueName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.venueName.Name = "venueName";
            this.venueName.Size = new System.Drawing.Size(140, 30);
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
            this.panel32.Location = new System.Drawing.Point(-4, -2);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(648, 89);
            this.panel32.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(148, 34);
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
            this.reminderBtn.Location = new System.Drawing.Point(466, 285);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(127, 35);
            this.reminderBtn.TabIndex = 16;
            this.reminderBtn.Text = "Set Reminder";
            this.reminderBtn.UseVisualStyleBackColor = false;
            this.reminderBtn.Click += new System.EventHandler(this.reminderBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.feedbackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(383, 22);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(146, 47);
            this.feedbackBtn.TabIndex = 17;
            this.feedbackBtn.Text = "Give Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Image = global::DBapplication.Properties.Resources.output_onlinepngtools__8_;
            this.reportBtn.Location = new System.Drawing.Point(536, 22);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(61, 47);
            this.reportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reportBtn.TabIndex = 15;
            this.reportBtn.TabStop = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // PublicEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(604, 332);
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
    }
}