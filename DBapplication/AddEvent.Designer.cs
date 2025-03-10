﻿namespace DBapplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EventName_label = new System.Windows.Forms.Label();
            this.EventName_textbox = new System.Windows.Forms.TextBox();
            this.EventDate_picker = new System.Windows.Forms.DateTimePicker();
            this.Description_label = new System.Windows.Forms.Label();
            this.Description_textbox = new System.Windows.Forms.TextBox();
            this.EventType_label = new System.Windows.Forms.Label();
            this.EventType_combobox = new System.Windows.Forms.ComboBox();
            this.StartTime_label = new System.Windows.Forms.Label();
            this.EndTime_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.Location_combobox = new System.Windows.Forms.ComboBox();
            this.AddEvent_button = new System.Windows.Forms.Button();
            this.StartTime_picker = new System.Windows.Forms.DateTimePicker();
            this.EndTime_picker = new System.Windows.Forms.DateTimePicker();
            this.Private_checkbox = new System.Windows.Forms.CheckBox();
            this.AddVenue_button = new System.Windows.Forms.Button();
            this.Tickets_label = new System.Windows.Forms.Label();
            this.TicketsDataGrid = new System.Windows.Forms.DataGridView();
            this.Service_label = new System.Windows.Forms.Label();
            this.ServicesDataGrid = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSponsor_button = new System.Windows.Forms.Button();
            this.TicketType_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tprice_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_tickets_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventName_label
            // 
            this.EventName_label.AutoSize = true;
            this.EventName_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EventName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.EventName_label.Location = new System.Drawing.Point(41, 59);
            this.EventName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventName_label.Name = "EventName_label";
            this.EventName_label.Size = new System.Drawing.Size(56, 21);
            this.EventName_label.TabIndex = 0;
            this.EventName_label.Text = "Name";
            this.EventName_label.Click += new System.EventHandler(this.EventName_label_Click);
            // 
            // EventName_textbox
            // 
            this.EventName_textbox.Location = new System.Drawing.Point(45, 85);
            this.EventName_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventName_textbox.Name = "EventName_textbox";
            this.EventName_textbox.Size = new System.Drawing.Size(210, 20);
            this.EventName_textbox.TabIndex = 1;
            // 
            // EventDate_picker
            // 
            this.EventDate_picker.CalendarForeColor = System.Drawing.Color.Black;
            this.EventDate_picker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.EventDate_picker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.EventDate_picker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.EventDate_picker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.EventDate_picker.CustomFormat = "yyyy-MM-dd";
            this.EventDate_picker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDate_picker.Location = new System.Drawing.Point(24, 87);
            this.EventDate_picker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventDate_picker.Name = "EventDate_picker";
            this.EventDate_picker.Size = new System.Drawing.Size(158, 29);
            this.EventDate_picker.TabIndex = 3;
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Description_label.Location = new System.Drawing.Point(41, 228);
            this.Description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(98, 21);
            this.Description_label.TabIndex = 4;
            this.Description_label.Text = "Description";
            // 
            // Description_textbox
            // 
            this.Description_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_textbox.Location = new System.Drawing.Point(45, 251);
            this.Description_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Description_textbox.Multiline = true;
            this.Description_textbox.Name = "Description_textbox";
            this.Description_textbox.Size = new System.Drawing.Size(210, 49);
            this.Description_textbox.TabIndex = 5;
            // 
            // EventType_label
            // 
            this.EventType_label.AutoSize = true;
            this.EventType_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EventType_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.EventType_label.Location = new System.Drawing.Point(41, 114);
            this.EventType_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EventType_label.Name = "EventType_label";
            this.EventType_label.Size = new System.Drawing.Size(46, 21);
            this.EventType_label.TabIndex = 6;
            this.EventType_label.Text = "Type";
            // 
            // EventType_combobox
            // 
            this.EventType_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventType_combobox.FormattingEnabled = true;
            this.EventType_combobox.Items.AddRange(new object[] {
            "Wedding",
            "Conference",
            "Concert",
            "Gala",
            "Party",
            "Other"});
            this.EventType_combobox.Location = new System.Drawing.Point(91, 117);
            this.EventType_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventType_combobox.Name = "EventType_combobox";
            this.EventType_combobox.Size = new System.Drawing.Size(164, 21);
            this.EventType_combobox.TabIndex = 7;
            // 
            // StartTime_label
            // 
            this.StartTime_label.AutoSize = true;
            this.StartTime_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StartTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.StartTime_label.Location = new System.Drawing.Point(20, 130);
            this.StartTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTime_label.Name = "StartTime_label";
            this.StartTime_label.Size = new System.Drawing.Size(49, 21);
            this.StartTime_label.TabIndex = 8;
            this.StartTime_label.Text = "From";
            // 
            // EndTime_label
            // 
            this.EndTime_label.AutoSize = true;
            this.EndTime_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EndTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.EndTime_label.Location = new System.Drawing.Point(113, 130);
            this.EndTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTime_label.Name = "EndTime_label";
            this.EndTime_label.Size = new System.Drawing.Size(28, 21);
            this.EndTime_label.TabIndex = 9;
            this.EndTime_label.Text = "To";
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Location_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Location_label.Location = new System.Drawing.Point(41, 146);
            this.Location_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(58, 21);
            this.Location_label.TabIndex = 11;
            this.Location_label.Text = "Venue";
            // 
            // Location_combobox
            // 
            this.Location_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location_combobox.FormattingEnabled = true;
            this.Location_combobox.Location = new System.Drawing.Point(103, 149);
            this.Location_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Location_combobox.Name = "Location_combobox";
            this.Location_combobox.Size = new System.Drawing.Size(152, 21);
            this.Location_combobox.TabIndex = 14;
            // 
            // AddEvent_button
            // 
            this.AddEvent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.AddEvent_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddEvent_button.ForeColor = System.Drawing.Color.White;
            this.AddEvent_button.Location = new System.Drawing.Point(91, 535);
            this.AddEvent_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddEvent_button.Name = "AddEvent_button";
            this.AddEvent_button.Size = new System.Drawing.Size(100, 50);
            this.AddEvent_button.TabIndex = 15;
            this.AddEvent_button.Text = "Add Event";
            this.AddEvent_button.UseVisualStyleBackColor = false;
            this.AddEvent_button.Click += new System.EventHandler(this.AddEvent_button_Click);
            // 
            // StartTime_picker
            // 
            this.StartTime_picker.CustomFormat = "HH:mm ";
            this.StartTime_picker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime_picker.Location = new System.Drawing.Point(24, 153);
            this.StartTime_picker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartTime_picker.Name = "StartTime_picker";
            this.StartTime_picker.ShowUpDown = true;
            this.StartTime_picker.Size = new System.Drawing.Size(65, 29);
            this.StartTime_picker.TabIndex = 16;
            this.StartTime_picker.Value = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            // 
            // EndTime_picker
            // 
            this.EndTime_picker.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.EndTime_picker.CustomFormat = "HH:mm";
            this.EndTime_picker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime_picker.Location = new System.Drawing.Point(117, 153);
            this.EndTime_picker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndTime_picker.Name = "EndTime_picker";
            this.EndTime_picker.ShowUpDown = true;
            this.EndTime_picker.Size = new System.Drawing.Size(65, 29);
            this.EndTime_picker.TabIndex = 17;
            this.EndTime_picker.Value = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            // 
            // Private_checkbox
            // 
            this.Private_checkbox.AutoSize = true;
            this.Private_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Private_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Private_checkbox.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Private_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Private_checkbox.Location = new System.Drawing.Point(140, 172);
            this.Private_checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Private_checkbox.Name = "Private_checkbox";
            this.Private_checkbox.Size = new System.Drawing.Size(115, 24);
            this.Private_checkbox.TabIndex = 13;
            this.Private_checkbox.Text = "Make Private";
            this.Private_checkbox.UseVisualStyleBackColor = true;
            // 
            // AddVenue_button
            // 
            this.AddVenue_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.AddVenue_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddVenue_button.ForeColor = System.Drawing.Color.White;
            this.AddVenue_button.Location = new System.Drawing.Point(437, 129);
            this.AddVenue_button.Name = "AddVenue_button";
            this.AddVenue_button.Size = new System.Drawing.Size(91, 38);
            this.AddVenue_button.TabIndex = 18;
            this.AddVenue_button.Text = "Add One!";
            this.AddVenue_button.UseVisualStyleBackColor = false;
            this.AddVenue_button.Click += new System.EventHandler(this.AddVenue_button_Click);
            // 
            // Tickets_label
            // 
            this.Tickets_label.AutoSize = true;
            this.Tickets_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Tickets_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Tickets_label.Location = new System.Drawing.Point(295, 386);
            this.Tickets_label.Name = "Tickets_label";
            this.Tickets_label.Size = new System.Drawing.Size(63, 21);
            this.Tickets_label.TabIndex = 19;
            this.Tickets_label.Text = "Tickets";
            // 
            // TicketsDataGrid
            // 
            this.TicketsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TicketsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TicketsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TicketsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketType_column,
            this.Tprice_column,
            this.Number_of_tickets_column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TicketsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.TicketsDataGrid.Location = new System.Drawing.Point(290, 410);
            this.TicketsDataGrid.Name = "TicketsDataGrid";
            this.TicketsDataGrid.RowHeadersVisible = false;
            this.TicketsDataGrid.RowHeadersWidth = 51;
            this.TicketsDataGrid.Size = new System.Drawing.Size(390, 101);
            this.TicketsDataGrid.TabIndex = 20;
            // 
            // Service_label
            // 
            this.Service_label.AutoSize = true;
            this.Service_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Service_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Service_label.Location = new System.Drawing.Point(286, 228);
            this.Service_label.Name = "Service_label";
            this.Service_label.Size = new System.Drawing.Size(156, 21);
            this.Service_label.TabIndex = 21;
            this.Service_label.Text = "Services (Optional)";
            // 
            // ServicesDataGrid
            // 
            this.ServicesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ServicesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.ServicesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName_column,
            this.ServiceType_column,
            this.Price_column});
            this.ServicesDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ServicesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ServicesDataGrid.Location = new System.Drawing.Point(290, 257);
            this.ServicesDataGrid.Name = "ServicesDataGrid";
            this.ServicesDataGrid.RowHeadersVisible = false;
            this.ServicesDataGrid.RowHeadersWidth = 51;
            this.ServicesDataGrid.Size = new System.Drawing.Size(390, 92);
            this.ServicesDataGrid.TabIndex = 24;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Refresh_Button.ForeColor = System.Drawing.Color.White;
            this.Refresh_Button.Location = new System.Drawing.Point(45, 175);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(79, 30);
            this.Refresh_Button.TabIndex = 25;
            this.Refresh_Button.Text = "Refresh List";
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EventDate_picker);
            this.panel1.Controls.Add(this.StartTime_picker);
            this.panel1.Controls.Add(this.StartTime_label);
            this.panel1.Controls.Add(this.EndTime_picker);
            this.panel1.Controls.Add(this.EndTime_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(45, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 206);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 46);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Event Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel32.Location = new System.Drawing.Point(0, -5);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(1291, 57);
            this.panel32.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 607);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 69);
            this.panel3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Can\'t Find Your Venue?\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSponsor_button
            // 
            this.AddSponsor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(184)))), ((int)(((byte)(212)))));
            this.AddSponsor_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSponsor_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSponsor_button.ForeColor = System.Drawing.Color.White;
            this.AddSponsor_button.Location = new System.Drawing.Point(381, 544);
            this.AddSponsor_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddSponsor_button.Name = "AddSponsor_button";
            this.AddSponsor_button.Size = new System.Drawing.Size(146, 41);
            this.AddSponsor_button.TabIndex = 30;
            this.AddSponsor_button.Text = "Add Sponsor";
            this.AddSponsor_button.UseVisualStyleBackColor = false;
            this.AddSponsor_button.Click += new System.EventHandler(this.AddSponsor_button_Click);
            // 
            // TicketType_column
            // 
            this.TicketType_column.HeaderText = "Ticket Type";
            this.TicketType_column.MinimumWidth = 6;
            this.TicketType_column.Name = "TicketType_column";
            this.TicketType_column.Width = 125;
            // 
            // Tprice_column
            // 
            this.Tprice_column.HeaderText = "Price";
            this.Tprice_column.MinimumWidth = 6;
            this.Tprice_column.Name = "Tprice_column";
            this.Tprice_column.Width = 125;
            // 
            // Number_of_tickets_column
            // 
            this.Number_of_tickets_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number_of_tickets_column.HeaderText = "Number of tickets";
            this.Number_of_tickets_column.MinimumWidth = 6;
            this.Number_of_tickets_column.Name = "Number_of_tickets_column";
            // 
            // ServiceName_column
            // 
            this.ServiceName_column.HeaderText = "Service Name";
            this.ServiceName_column.MinimumWidth = 6;
            this.ServiceName_column.Name = "ServiceName_column";
            this.ServiceName_column.Width = 125;
            // 
            // ServiceType_column
            // 
            this.ServiceType_column.HeaderText = "Service Type";
            this.ServiceType_column.MinimumWidth = 6;
            this.ServiceType_column.Name = "ServiceType_column";
            this.ServiceType_column.Width = 125;
            // 
            // Price_column
            // 
            this.Price_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price_column.HeaderText = "Price";
            this.Price_column.MinimumWidth = 6;
            this.Price_column.Name = "Price_column";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(711, 647);
            this.Controls.Add(this.AddSponsor_button);
            this.Controls.Add(this.AddEvent_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.ServicesDataGrid);
            this.Controls.Add(this.Service_label);
            this.Controls.Add(this.TicketsDataGrid);
            this.Controls.Add(this.Tickets_label);
            this.Controls.Add(this.AddVenue_button);
            this.Controls.Add(this.Location_combobox);
            this.Controls.Add(this.Private_checkbox);
            this.Controls.Add(this.Location_label);
            this.Controls.Add(this.EventType_combobox);
            this.Controls.Add(this.EventType_label);
            this.Controls.Add(this.Description_textbox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.EventName_textbox);
            this.Controls.Add(this.EventName_label);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventName_label;
        private System.Windows.Forms.TextBox EventName_textbox;
        private System.Windows.Forms.DateTimePicker EventDate_picker;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Description_textbox;
        private System.Windows.Forms.Label EventType_label;
        private System.Windows.Forms.ComboBox EventType_combobox;
        private System.Windows.Forms.Label StartTime_label;
        private System.Windows.Forms.Label EndTime_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.ComboBox Location_combobox;
        private System.Windows.Forms.Button AddEvent_button;
        private System.Windows.Forms.DateTimePicker StartTime_picker;
        private System.Windows.Forms.DateTimePicker EndTime_picker;
        private System.Windows.Forms.CheckBox Private_checkbox;
        private System.Windows.Forms.Button AddVenue_button;
        private System.Windows.Forms.Label Tickets_label;
        private System.Windows.Forms.DataGridView TicketsDataGrid;
        private System.Windows.Forms.Label Service_label;
        private System.Windows.Forms.DataGridView ServicesDataGrid;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSponsor_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketType_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tprice_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_tickets_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_column;
    }
}