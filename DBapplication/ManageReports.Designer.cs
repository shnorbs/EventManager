namespace DBapplication
{
    partial class ManageReports
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
            this.EventButton = new System.Windows.Forms.Button();
            this.FeedbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reports On";
            // 
            // EventButton
            // 
            this.EventButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.EventButton.Location = new System.Drawing.Point(141, 155);
            this.EventButton.Name = "EventButton";
            this.EventButton.Size = new System.Drawing.Size(147, 105);
            this.EventButton.TabIndex = 1;
            this.EventButton.Text = "Event";
            this.EventButton.UseVisualStyleBackColor = true;
            this.EventButton.Click += new System.EventHandler(this.EventButton_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.FeedbackButton.Location = new System.Drawing.Point(141, 266);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(147, 110);
            this.FeedbackButton.TabIndex = 2;
            this.FeedbackButton.Text = "Feedback";
            this.FeedbackButton.UseVisualStyleBackColor = true;
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // ManageReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.FeedbackButton);
            this.Controls.Add(this.EventButton);
            this.Controls.Add(this.label1);
            this.Name = "ManageReports";
            this.Text = "Manage Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EventButton;
        private System.Windows.Forms.Button FeedbackButton;
    }
}