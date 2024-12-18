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
            this.SuspendLayout();
            // 
            // VenueAddress_label
            // 
            this.VenueAddress_label.AutoSize = true;
            this.VenueAddress_label.Location = new System.Drawing.Point(36, 49);
            this.VenueAddress_label.Name = "VenueAddress_label";
            this.VenueAddress_label.Size = new System.Drawing.Size(79, 13);
            this.VenueAddress_label.TabIndex = 0;
            this.VenueAddress_label.Text = "Venue Address";
            // 
            // VenueName_label
            // 
            this.VenueName_label.AutoSize = true;
            this.VenueName_label.Location = new System.Drawing.Point(36, 90);
            this.VenueName_label.Name = "VenueName_label";
            this.VenueName_label.Size = new System.Drawing.Size(69, 13);
            this.VenueName_label.TabIndex = 1;
            this.VenueName_label.Text = "Venue Name";
            // 
            // Capacity_label
            // 
            this.Capacity_label.AutoSize = true;
            this.Capacity_label.Location = new System.Drawing.Point(36, 127);
            this.Capacity_label.Name = "Capacity_label";
            this.Capacity_label.Size = new System.Drawing.Size(48, 13);
            this.Capacity_label.TabIndex = 2;
            this.Capacity_label.Text = "Capacity";
            // 
            // BookingPrice_label
            // 
            this.BookingPrice_label.AutoSize = true;
            this.BookingPrice_label.Location = new System.Drawing.Point(36, 164);
            this.BookingPrice_label.Name = "BookingPrice_label";
            this.BookingPrice_label.Size = new System.Drawing.Size(73, 13);
            this.BookingPrice_label.TabIndex = 3;
            this.BookingPrice_label.Text = "Booking Price";
            // 
            // VenueAddress_textbox
            // 
            this.VenueAddress_textbox.Location = new System.Drawing.Point(127, 42);
            this.VenueAddress_textbox.Name = "VenueAddress_textbox";
            this.VenueAddress_textbox.Size = new System.Drawing.Size(100, 20);
            this.VenueAddress_textbox.TabIndex = 4;
            // 
            // VenueName_textbox
            // 
            this.VenueName_textbox.Location = new System.Drawing.Point(127, 83);
            this.VenueName_textbox.Name = "VenueName_textbox";
            this.VenueName_textbox.Size = new System.Drawing.Size(100, 20);
            this.VenueName_textbox.TabIndex = 5;
            // 
            // Capacity_textbox
            // 
            this.Capacity_textbox.Location = new System.Drawing.Point(127, 124);
            this.Capacity_textbox.Name = "Capacity_textbox";
            this.Capacity_textbox.Size = new System.Drawing.Size(100, 20);
            this.Capacity_textbox.TabIndex = 6;
            // 
            // BookingPrice_textbox
            // 
            this.BookingPrice_textbox.Location = new System.Drawing.Point(127, 161);
            this.BookingPrice_textbox.Name = "BookingPrice_textbox";
            this.BookingPrice_textbox.Size = new System.Drawing.Size(100, 20);
            this.BookingPrice_textbox.TabIndex = 7;
            // 
            // AddVenue_button
            // 
            this.AddVenue_button.Location = new System.Drawing.Point(39, 204);
            this.AddVenue_button.Name = "AddVenue_button";
            this.AddVenue_button.Size = new System.Drawing.Size(114, 50);
            this.AddVenue_button.TabIndex = 8;
            this.AddVenue_button.Text = "Add Venue";
            this.AddVenue_button.UseVisualStyleBackColor = true;
            this.AddVenue_button.Click += new System.EventHandler(this.AddVenue_button_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(270, 204);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(88, 54);
            this.Return_button.TabIndex = 9;
            this.Return_button.Text = "Return Back To Add Event";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // AddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AddVenue";
            this.Text = "AddVenue";
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
    }
}