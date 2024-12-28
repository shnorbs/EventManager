namespace DBapplication
{
    partial class AllFeedback
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
            this.FeedbackGrid = new System.Windows.Forms.DataGridView();
            this.ReportButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedbackGrid
            // 
            this.FeedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackGrid.Location = new System.Drawing.Point(46, 24);
            this.FeedbackGrid.Name = "FeedbackGrid";
            this.FeedbackGrid.RowHeadersWidth = 51;
            this.FeedbackGrid.RowTemplate.Height = 26;
            this.FeedbackGrid.Size = new System.Drawing.Size(691, 356);
            this.FeedbackGrid.TabIndex = 0;
            this.FeedbackGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedbackGrid_CellContentClick);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(446, 396);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(141, 42);
            this.ReportButton.TabIndex = 1;
            this.ReportButton.Text = "Report Feedback";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(165, 396);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(216, 42);
            this.Description.TabIndex = 2;
            // 
            // AllFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.FeedbackGrid);
            this.Name = "AllFeedback";
            this.Text = "All Feedback";
            this.Load += new System.EventHandler(this.AllFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FeedbackGrid;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.TextBox Description;
    }
}