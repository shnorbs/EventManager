namespace DBapplication
{
    partial class Statstics
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
            this.EventOrganizers = new System.Windows.Forms.DataGridView();
            this.Organizer_Events = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Popular_Venues_button = new System.Windows.Forms.Button();
            this.PopularVenues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EventOrganizers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularVenues)).BeginInit();
            this.SuspendLayout();
            // 
            // EventOrganizers
            // 
            this.EventOrganizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventOrganizers.Location = new System.Drawing.Point(-8, -3);
            this.EventOrganizers.Name = "EventOrganizers";
            this.EventOrganizers.RowHeadersWidth = 51;
            this.EventOrganizers.RowTemplate.Height = 24;
            this.EventOrganizers.Size = new System.Drawing.Size(526, 208);
            this.EventOrganizers.TabIndex = 0;
            this.EventOrganizers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventOrganizers_CellContentClick);
            // 
            // Organizer_Events
            // 
            this.Organizer_Events.Location = new System.Drawing.Point(12, 284);
            this.Organizer_Events.Name = "Organizer_Events";
            this.Organizer_Events.Size = new System.Drawing.Size(139, 56);
            this.Organizer_Events.TabIndex = 1;
            this.Organizer_Events.Text = "Show Events for Organizer";
            this.Organizer_Events.UseVisualStyleBackColor = true;
            this.Organizer_Events.Click += new System.EventHandler(this.Organizer_Events_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Managerial Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Popular_Venues_button
            // 
            this.Popular_Venues_button.Location = new System.Drawing.Point(172, 284);
            this.Popular_Venues_button.Name = "Popular_Venues_button";
            this.Popular_Venues_button.Size = new System.Drawing.Size(139, 56);
            this.Popular_Venues_button.TabIndex = 3;
            this.Popular_Venues_button.Text = "Show Most Popular Venues";
            this.Popular_Venues_button.UseVisualStyleBackColor = true;
            this.Popular_Venues_button.Click += new System.EventHandler(this.Popular_Venues_button_Click);
            // 
            // PopularVenues
            // 
            this.PopularVenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopularVenues.Location = new System.Drawing.Point(515, -3);
            this.PopularVenues.Name = "PopularVenues";
            this.PopularVenues.RowHeadersWidth = 51;
            this.PopularVenues.RowTemplate.Height = 24;
            this.PopularVenues.Size = new System.Drawing.Size(562, 208);
            this.PopularVenues.TabIndex = 4;
            // 
            // Statstics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.PopularVenues);
            this.Controls.Add(this.Popular_Venues_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Organizer_Events);
            this.Controls.Add(this.EventOrganizers);
            this.Name = "Statstics";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Statstics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventOrganizers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularVenues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EventOrganizers;
        private System.Windows.Forms.Button Organizer_Events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Popular_Venues_button;
        private System.Windows.Forms.DataGridView PopularVenues;
    }
}