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
            this.SponsorDataGrid = new System.Windows.Forms.DataGridView();
            this.AddSponsor_button = new System.Windows.Forms.Button();
            this.CompanyName_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSponsored_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SponsorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SponsorDataGrid
            // 
            this.SponsorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SponsorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName_column,
            this.AmountSponsored_column});
            this.SponsorDataGrid.Location = new System.Drawing.Point(147, 58);
            this.SponsorDataGrid.Name = "SponsorDataGrid";
            this.SponsorDataGrid.Size = new System.Drawing.Size(443, 282);
            this.SponsorDataGrid.TabIndex = 0;
            // 
            // AddSponsor_button
            // 
            this.AddSponsor_button.Location = new System.Drawing.Point(301, 346);
            this.AddSponsor_button.Name = "AddSponsor_button";
            this.AddSponsor_button.Size = new System.Drawing.Size(129, 53);
            this.AddSponsor_button.TabIndex = 1;
            this.AddSponsor_button.Text = "Add Sponsor";
            this.AddSponsor_button.UseVisualStyleBackColor = true;
            this.AddSponsor_button.Click += new System.EventHandler(this.AddSponsor_button_Click);
            // 
            // CompanyName_column
            // 
            this.CompanyName_column.HeaderText = "Company Name";
            this.CompanyName_column.Name = "CompanyName_column";
            this.CompanyName_column.Width = 200;
            // 
            // AmountSponsored_column
            // 
            this.AmountSponsored_column.HeaderText = "Amount Sponsored";
            this.AmountSponsored_column.Name = "AmountSponsored_column";
            this.AmountSponsored_column.Width = 200;
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Button AddSponsor_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSponsored_column;
    }
}