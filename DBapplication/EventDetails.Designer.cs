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
            this.SuspendLayout();
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold);
            this.eventName.Location = new System.Drawing.Point(8, 6);
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
            this.description.Location = new System.Drawing.Point(8, 104);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(517, 84);
            this.description.TabIndex = 1;
            this.description.Text = "DESCRIPTION";
            // 
            // eventType
            // 
            this.eventType.AutoSize = true;
            this.eventType.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventType.Location = new System.Drawing.Point(9, 42);
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
            this.time.Location = new System.Drawing.Point(7, 188);
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
            this.label2.Location = new System.Drawing.Point(182, 188);
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
            this.startTimeLbl.Location = new System.Drawing.Point(84, 188);
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
            this.endTimeLbl.Location = new System.Drawing.Point(225, 188);
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
            this.label1.Location = new System.Drawing.Point(29, 237);
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
            this.venueName.Location = new System.Drawing.Point(78, 237);
            this.venueName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.venueName.Name = "venueName";
            this.venueName.Size = new System.Drawing.Size(140, 30);
            this.venueName.TabIndex = 9;
            this.venueName.Text = "Venue Name";
            // 
            // PublicEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.venueName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTimeLbl);
            this.Controls.Add(this.startTimeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.eventType);
            this.Controls.Add(this.description);
            this.Controls.Add(this.eventName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PublicEventDetails";
            this.Text = "Event Details";
            this.Load += new System.EventHandler(this.EventDetails_Load);
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
    }
}