namespace DBapplication
{
    partial class AddVenue
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
            this.VenueAddress_label = new System.Windows.Forms.Label();
            this.VenueName_label = new System.Windows.Forms.Label();
            this.Capacity_label = new System.Windows.Forms.Label();
            this.BookingPrice_label = new System.Windows.Forms.Label();
            this.VenueAddress_textbox = new System.Windows.Forms.TextBox();
            this.VenueName_textbox = new System.Windows.Forms.TextBox();
            this.Capacity_textbox = new System.Windows.Forms.TextBox();
            this.BookingPrice_textbox = new System.Windows.Forms.TextBox();
            this.AddVenue_button = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.FacilityType_label = new System.Windows.Forms.Label();
            this.FacilityType_textbox = new System.Windows.Forms.TextBox();
            this.FacilityType_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // VenueAddress_label
            // 
            this.VenueAddress_label.AutoSize = true;
            this.VenueAddress_label.Location = new System.Drawing.Point(48, 60);
            this.VenueAddress_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VenueAddress_label.Name = "VenueAddress_label";
            this.VenueAddress_label.Size = new System.Drawing.Size(100, 16);
            this.VenueAddress_label.TabIndex = 0;
            this.VenueAddress_label.Text = "Venue Address";
            // 
            // VenueName_label
            // 
            this.VenueName_label.AutoSize = true;
            this.VenueName_label.Location = new System.Drawing.Point(48, 111);
            this.VenueName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VenueName_label.Name = "VenueName_label";
            this.VenueName_label.Size = new System.Drawing.Size(86, 16);
            this.VenueName_label.TabIndex = 1;
            this.VenueName_label.Text = "Venue Name";
            // 
            // Capacity_label
            // 
            this.Capacity_label.AutoSize = true;
            this.Capacity_label.Location = new System.Drawing.Point(48, 156);
            this.Capacity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Capacity_label.Name = "Capacity_label";
            this.Capacity_label.Size = new System.Drawing.Size(60, 16);
            this.Capacity_label.TabIndex = 2;
            this.Capacity_label.Text = "Capacity";
            // 
            // BookingPrice_label
            // 
            this.BookingPrice_label.AutoSize = true;
            this.BookingPrice_label.Location = new System.Drawing.Point(48, 202);
            this.BookingPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingPrice_label.Name = "BookingPrice_label";
            this.BookingPrice_label.Size = new System.Drawing.Size(91, 16);
            this.BookingPrice_label.TabIndex = 3;
            this.BookingPrice_label.Text = "Booking Price";
            // 
            // VenueAddress_textbox
            // 
            this.VenueAddress_textbox.Location = new System.Drawing.Point(169, 52);
            this.VenueAddress_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VenueAddress_textbox.Name = "VenueAddress_textbox";
            this.VenueAddress_textbox.Size = new System.Drawing.Size(132, 22);
            this.VenueAddress_textbox.TabIndex = 4;
            // 
            // VenueName_textbox
            // 
            this.VenueName_textbox.Location = new System.Drawing.Point(169, 102);
            this.VenueName_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VenueName_textbox.Name = "VenueName_textbox";
            this.VenueName_textbox.Size = new System.Drawing.Size(132, 22);
            this.VenueName_textbox.TabIndex = 5;
            // 
            // Capacity_textbox
            // 
            this.Capacity_textbox.Location = new System.Drawing.Point(169, 153);
            this.Capacity_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Capacity_textbox.Name = "Capacity_textbox";
            this.Capacity_textbox.Size = new System.Drawing.Size(132, 22);
            this.Capacity_textbox.TabIndex = 6;
            // 
            // BookingPrice_textbox
            // 
            this.BookingPrice_textbox.Location = new System.Drawing.Point(169, 198);
            this.BookingPrice_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookingPrice_textbox.Name = "BookingPrice_textbox";
            this.BookingPrice_textbox.Size = new System.Drawing.Size(132, 22);
            this.BookingPrice_textbox.TabIndex = 7;
            // 
            // AddVenue_button
            // 
            this.AddVenue_button.Location = new System.Drawing.Point(60, 336);
            this.AddVenue_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddVenue_button.Name = "AddVenue_button";
            this.AddVenue_button.Size = new System.Drawing.Size(152, 62);
            this.AddVenue_button.TabIndex = 8;
            this.AddVenue_button.Text = "Add Venue";
            this.AddVenue_button.UseVisualStyleBackColor = true;
            this.AddVenue_button.Click += new System.EventHandler(this.AddVenue_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(356, 332);
            this.Return_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(152, 66);
            this.Return_button.TabIndex = 9;
            this.Return_button.Text = "Return Back To Add Event";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // FacilityType_label
            // 
            this.FacilityType_label.AutoSize = true;
            this.FacilityType_label.Location = new System.Drawing.Point(48, 258);
            this.FacilityType_label.Name = "FacilityType_label";
            this.FacilityType_label.Size = new System.Drawing.Size(84, 16);
            this.FacilityType_label.TabIndex = 10;
            this.FacilityType_label.Text = "Facility Type";
            // 
            // FacilityType_textbox
            // 
            this.FacilityType_textbox.Location = new System.Drawing.Point(324, 260);
            this.FacilityType_textbox.Name = "FacilityType_textbox";
            this.FacilityType_textbox.Size = new System.Drawing.Size(132, 22);
            this.FacilityType_textbox.TabIndex = 14;
            this.FacilityType_textbox.TextChanged += new System.EventHandler(this.FacilityType_textbox_TextChanged);
            // 
            // FacilityType_combobox
            // 
            this.FacilityType_combobox.FormattingEnabled = true;
            this.FacilityType_combobox.Items.AddRange(new object[] {
            "Conference Room",
            "Projector",
            "Outdoor Stage",
            "Sound System",
            "VIP Lounge",
            "Bar",
            "Parking Lot",
            "WiFi",
            "Dance Floor",
            "Catering Service",
            "Other"});
            this.FacilityType_combobox.Location = new System.Drawing.Point(169, 258);
            this.FacilityType_combobox.Name = "FacilityType_combobox";
            this.FacilityType_combobox.Size = new System.Drawing.Size(132, 24);
            this.FacilityType_combobox.TabIndex = 15;
            this.FacilityType_combobox.SelectedIndexChanged += new System.EventHandler(this.FacilityType_combobox_SelectedIndexChanged);
            // 
            // AddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FacilityType_combobox);
            this.Controls.Add(this.FacilityType_textbox);
            this.Controls.Add(this.FacilityType_label);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.AddVenue_button);
            this.Controls.Add(this.BookingPrice_textbox);
            this.Controls.Add(this.Capacity_textbox);
            this.Controls.Add(this.VenueName_textbox);
            this.Controls.Add(this.VenueAddress_textbox);
            this.Controls.Add(this.BookingPrice_label);
            this.Controls.Add(this.Capacity_label);
            this.Controls.Add(this.VenueName_label);
            this.Controls.Add(this.VenueAddress_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVenue";
            this.Text = "Add Venue";
            this.Load += new System.EventHandler(this.AddVenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VenueAddress_label;
        private System.Windows.Forms.Label VenueName_label;
        private System.Windows.Forms.Label Capacity_label;
        private System.Windows.Forms.Label BookingPrice_label;
        private System.Windows.Forms.TextBox VenueAddress_textbox;
        private System.Windows.Forms.TextBox VenueName_textbox;
        private System.Windows.Forms.TextBox Capacity_textbox;
        private System.Windows.Forms.TextBox BookingPrice_textbox;
        private System.Windows.Forms.Button AddVenue_button;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Label FacilityType_label;
        private System.Windows.Forms.TextBox FacilityType_textbox;
        private System.Windows.Forms.ComboBox FacilityType_combobox;
    }
}