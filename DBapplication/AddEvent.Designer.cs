namespace DBapplication
{
    partial class AddEvent
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
            this.EventName_label = new System.Windows.Forms.Label();
            this.EventName_textbox = new System.Windows.Forms.TextBox();
            this.EventDate_label = new System.Windows.Forms.Label();
            this.EventDate_picker = new System.Windows.Forms.DateTimePicker();
            this.Description_label = new System.Windows.Forms.Label();
            this.Description_textbox = new System.Windows.Forms.TextBox();
            this.EventType_label = new System.Windows.Forms.Label();
            this.EventType_combobox = new System.Windows.Forms.ComboBox();
            this.StartTime_label = new System.Windows.Forms.Label();
            this.EndTime_label = new System.Windows.Forms.Label();
            this.PrivateEvent_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.Location_combobox = new System.Windows.Forms.ComboBox();
            this.AddEvent_button = new System.Windows.Forms.Button();
            this.StartTime_picker = new System.Windows.Forms.DateTimePicker();
            this.EndTime_picker = new System.Windows.Forms.DateTimePicker();
            this.Private_checkbox = new System.Windows.Forms.CheckBox();
            this.AddVenue_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventName_label
            // 
            this.EventName_label.AutoSize = true;
            this.EventName_label.Location = new System.Drawing.Point(35, 32);
            this.EventName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventName_label.Name = "EventName_label";
            this.EventName_label.Size = new System.Drawing.Size(66, 13);
            this.EventName_label.TabIndex = 0;
            this.EventName_label.Text = "Event Name";
            // 
            // EventName_textbox
            // 
            this.EventName_textbox.Location = new System.Drawing.Point(116, 32);
            this.EventName_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.EventName_textbox.Name = "EventName_textbox";
            this.EventName_textbox.Size = new System.Drawing.Size(158, 20);
            this.EventName_textbox.TabIndex = 1;
            // 
            // EventDate_label
            // 
            this.EventDate_label.AutoSize = true;
            this.EventDate_label.Location = new System.Drawing.Point(35, 76);
            this.EventDate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventDate_label.Name = "EventDate_label";
            this.EventDate_label.Size = new System.Drawing.Size(61, 13);
            this.EventDate_label.TabIndex = 2;
            this.EventDate_label.Text = "Event Date";
            // 
            // EventDate_picker
            // 
            this.EventDate_picker.CustomFormat = "yyyy-MM-dd";
            this.EventDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDate_picker.Location = new System.Drawing.Point(116, 72);
            this.EventDate_picker.Margin = new System.Windows.Forms.Padding(2);
            this.EventDate_picker.Name = "EventDate_picker";
            this.EventDate_picker.Size = new System.Drawing.Size(231, 20);
            this.EventDate_picker.TabIndex = 3;
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(35, 122);
            this.Description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 4;
            this.Description_label.Text = "Description";
            // 
            // Description_textbox
            // 
            this.Description_textbox.Location = new System.Drawing.Point(116, 119);
            this.Description_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Description_textbox.Name = "Description_textbox";
            this.Description_textbox.Size = new System.Drawing.Size(158, 20);
            this.Description_textbox.TabIndex = 5;
            // 
            // EventType_label
            // 
            this.EventType_label.AutoSize = true;
            this.EventType_label.Location = new System.Drawing.Point(35, 171);
            this.EventType_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventType_label.Name = "EventType_label";
            this.EventType_label.Size = new System.Drawing.Size(62, 13);
            this.EventType_label.TabIndex = 6;
            this.EventType_label.Text = "Event Type";
            // 
            // EventType_combobox
            // 
            this.EventType_combobox.FormattingEnabled = true;
            this.EventType_combobox.Items.AddRange(new object[] {
            "Wedding",
            "Conference",
            "Concert",
            "Gala",
            "Party",
            "Other"});
            this.EventType_combobox.Location = new System.Drawing.Point(116, 168);
            this.EventType_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.EventType_combobox.Name = "EventType_combobox";
            this.EventType_combobox.Size = new System.Drawing.Size(158, 21);
            this.EventType_combobox.TabIndex = 7;
            // 
            // StartTime_label
            // 
            this.StartTime_label.AutoSize = true;
            this.StartTime_label.Location = new System.Drawing.Point(35, 219);
            this.StartTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTime_label.Name = "StartTime_label";
            this.StartTime_label.Size = new System.Drawing.Size(55, 13);
            this.StartTime_label.TabIndex = 8;
            this.StartTime_label.Text = "Start Time";
            // 
            // EndTime_label
            // 
            this.EndTime_label.AutoSize = true;
            this.EndTime_label.Location = new System.Drawing.Point(35, 257);
            this.EndTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTime_label.Name = "EndTime_label";
            this.EndTime_label.Size = new System.Drawing.Size(52, 13);
            this.EndTime_label.TabIndex = 9;
            this.EndTime_label.Text = "End Time";
            // 
            // PrivateEvent_label
            // 
            this.PrivateEvent_label.AutoSize = true;
            this.PrivateEvent_label.Location = new System.Drawing.Point(35, 297);
            this.PrivateEvent_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrivateEvent_label.Name = "PrivateEvent_label";
            this.PrivateEvent_label.Size = new System.Drawing.Size(71, 13);
            this.PrivateEvent_label.TabIndex = 10;
            this.PrivateEvent_label.Text = "Private Event";
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Location = new System.Drawing.Point(35, 336);
            this.Location_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(48, 13);
            this.Location_label.TabIndex = 11;
            this.Location_label.Text = "Location";
            // 
            // Location_combobox
            // 
            this.Location_combobox.FormattingEnabled = true;
            this.Location_combobox.Location = new System.Drawing.Point(116, 332);
            this.Location_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.Location_combobox.Name = "Location_combobox";
            this.Location_combobox.Size = new System.Drawing.Size(158, 21);
            this.Location_combobox.TabIndex = 14;
            // 
            // AddEvent_button
            // 
            this.AddEvent_button.Location = new System.Drawing.Point(38, 392);
            this.AddEvent_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddEvent_button.Name = "AddEvent_button";
            this.AddEvent_button.Size = new System.Drawing.Size(100, 50);
            this.AddEvent_button.TabIndex = 15;
            this.AddEvent_button.Text = "Add Event";
            this.AddEvent_button.UseVisualStyleBackColor = true;
            this.AddEvent_button.Click += new System.EventHandler(this.AddEvent_button_Click);
            // 
            // StartTime_picker
            // 
            this.StartTime_picker.CustomFormat = "HH:mm ";
            this.StartTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime_picker.Location = new System.Drawing.Point(116, 219);
            this.StartTime_picker.Margin = new System.Windows.Forms.Padding(2);
            this.StartTime_picker.Name = "StartTime_picker";
            this.StartTime_picker.ShowUpDown = true;
            this.StartTime_picker.Size = new System.Drawing.Size(54, 20);
            this.StartTime_picker.TabIndex = 16;
            // 
            // EndTime_picker
            // 
            this.EndTime_picker.CustomFormat = "HH:mm";
            this.EndTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime_picker.Location = new System.Drawing.Point(116, 257);
            this.EndTime_picker.Margin = new System.Windows.Forms.Padding(2);
            this.EndTime_picker.Name = "EndTime_picker";
            this.EndTime_picker.ShowUpDown = true;
            this.EndTime_picker.Size = new System.Drawing.Size(54, 20);
            this.EndTime_picker.TabIndex = 17;
            // 
            // Private_checkbox
            // 
            this.Private_checkbox.AutoSize = true;
            this.Private_checkbox.Location = new System.Drawing.Point(116, 297);
            this.Private_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.Private_checkbox.Name = "Private_checkbox";
            this.Private_checkbox.Size = new System.Drawing.Size(59, 17);
            this.Private_checkbox.TabIndex = 13;
            this.Private_checkbox.Text = "Private";
            this.Private_checkbox.UseVisualStyleBackColor = true;
            // 
            // AddVenue_button
            // 
            this.AddVenue_button.Location = new System.Drawing.Point(642, 64);
            this.AddVenue_button.Name = "AddVenue_button";
            this.AddVenue_button.Size = new System.Drawing.Size(186, 75);
            this.AddVenue_button.TabIndex = 18;
            this.AddVenue_button.Text = "Add Venue";
            this.AddVenue_button.UseVisualStyleBackColor = true;
            this.AddVenue_button.Click += new System.EventHandler(this.AddVenue_button_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 575);
            this.Controls.Add(this.AddVenue_button);
            this.Controls.Add(this.StartTime_picker);
            this.Controls.Add(this.AddEvent_button);
            this.Controls.Add(this.Location_combobox);
            this.Controls.Add(this.Private_checkbox);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.PrivateEvent_label);
            this.Controls.Add(this.EndTime_label);
            this.Controls.Add(this.StartTime_label);
            this.Controls.Add(this.EventType_combobox);
            this.Controls.Add(this.EventType_label);
            this.Controls.Add(this.Description_textbox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.EventDate_picker);
            this.Controls.Add(this.EventDate_label);
            this.Controls.Add(this.EventName_textbox);
            this.Controls.Add(this.EventName_label);
            this.Controls.Add(this.EndTime_picker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventName_label;
        private System.Windows.Forms.TextBox EventName_textbox;
        private System.Windows.Forms.Label EventDate_label;
        private System.Windows.Forms.DateTimePicker EventDate_picker;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Description_textbox;
        private System.Windows.Forms.Label EventType_label;
        private System.Windows.Forms.ComboBox EventType_combobox;
        private System.Windows.Forms.Label StartTime_label;
        private System.Windows.Forms.Label EndTime_label;
        private System.Windows.Forms.Label PrivateEvent_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.ComboBox Location_combobox;
        private System.Windows.Forms.Button AddEvent_button;
        private System.Windows.Forms.DateTimePicker StartTime_picker;
        private System.Windows.Forms.DateTimePicker EndTime_picker;
        private System.Windows.Forms.CheckBox Private_checkbox;
        private System.Windows.Forms.Button AddVenue_button;
    }
}