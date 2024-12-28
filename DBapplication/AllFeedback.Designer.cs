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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReportButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.FeedbackGrid = new System.Windows.Forms.DataGridView();
            this.VenueAddress_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(490, 330);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(141, 34);
            this.ReportButton.TabIndex = 1;
            this.ReportButton.Text = "Report Feedback";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(194, 330);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(186, 34);
            this.Description.TabIndex = 2;
            // 
            // FeedbackGrid
            // 
            this.FeedbackGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.FeedbackGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeedbackGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.FeedbackGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeedbackGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FeedbackGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeedbackGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.FeedbackGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.FeedbackGrid.Location = new System.Drawing.Point(39, 20);
            this.FeedbackGrid.Name = "FeedbackGrid";
            this.FeedbackGrid.RowHeadersVisible = false;
            this.FeedbackGrid.RowHeadersWidth = 51;
            this.FeedbackGrid.Size = new System.Drawing.Size(592, 289);
            this.FeedbackGrid.TabIndex = 31;
            // 
            // VenueAddress_label
            // 
            this.VenueAddress_label.AutoSize = true;
            this.VenueAddress_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.VenueAddress_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.VenueAddress_label.Location = new System.Drawing.Point(35, 337);
            this.VenueAddress_label.Name = "VenueAddress_label";
            this.VenueAddress_label.Size = new System.Drawing.Size(157, 21);
            this.VenueAddress_label.TabIndex = 32;
            this.VenueAddress_label.Text = "Report Description:";
            // 
            // AllFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(686, 375);
            this.Controls.Add(this.VenueAddress_label);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.FeedbackGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllFeedback";
            this.Text = "All Feedback";
            this.Load += new System.EventHandler(this.AllFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.DataGridView FeedbackGrid;
        private System.Windows.Forms.Label VenueAddress_label;
    }
}