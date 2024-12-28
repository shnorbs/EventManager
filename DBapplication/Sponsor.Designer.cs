namespace DBapplication
{
    partial class Sponsor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SponsorDataGrid = new System.Windows.Forms.DataGridView();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Sponsored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSponsor_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SponsorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SponsorDataGrid
            // 
            this.SponsorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SponsorDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.SponsorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SponsorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.SponsorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SponsorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SponsorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SponsorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company_Name,
            this.Amount_Sponsored});
            this.SponsorDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SponsorDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SponsorDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.SponsorDataGrid.Location = new System.Drawing.Point(12, 12);
            this.SponsorDataGrid.Name = "SponsorDataGrid";
            this.SponsorDataGrid.RowHeadersVisible = false;
            this.SponsorDataGrid.RowHeadersWidth = 51;
            this.SponsorDataGrid.Size = new System.Drawing.Size(501, 282);
            this.SponsorDataGrid.TabIndex = 31;
            // 
            // Company_Name
            // 
            this.Company_Name.HeaderText = "Company_Name";
            this.Company_Name.Name = "Company_Name";
            // 
            // Amount_Sponsored
            // 
            this.Amount_Sponsored.HeaderText = "Amount_Sponsored";
            this.Amount_Sponsored.Name = "Amount_Sponsored";
            // 
            // AddSponsor_button
            // 
            this.AddSponsor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.AddSponsor_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddSponsor_button.ForeColor = System.Drawing.Color.White;
            this.AddSponsor_button.Location = new System.Drawing.Point(184, 299);
            this.AddSponsor_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddSponsor_button.Name = "AddSponsor_button";
            this.AddSponsor_button.Size = new System.Drawing.Size(147, 29);
            this.AddSponsor_button.TabIndex = 32;
            this.AddSponsor_button.Text = "Add Sponsor";
            this.AddSponsor_button.UseVisualStyleBackColor = false;
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(525, 332);
            this.Controls.Add(this.AddSponsor_button);
            this.Controls.Add(this.SponsorDataGrid);
            this.Name = "Sponsor";
            this.Text = "Sponsor";
            this.Load += new System.EventHandler(this.Sponsor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SponsorDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView SponsorDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Sponsored;
        private System.Windows.Forms.Button AddSponsor_button;
    }
}