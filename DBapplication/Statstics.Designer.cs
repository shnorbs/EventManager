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
            this.Managerial = new System.Windows.Forms.DataGridView();
            this.Organizer_Events = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Popular_Venues_button = new System.Windows.Forms.Button();
            this.Statstical = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Managerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statstical)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Managerial
            // 
            this.Managerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Managerial.Location = new System.Drawing.Point(13, 40);
            this.Managerial.Name = "Managerial";
            this.Managerial.RowHeadersWidth = 51;
            this.Managerial.RowTemplate.Height = 24;
            this.Managerial.Size = new System.Drawing.Size(490, 208);
            this.Managerial.TabIndex = 0;
            this.Managerial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventOrganizers_CellContentClick);
            // 
            // Organizer_Events
            // 
            this.Organizer_Events.Location = new System.Drawing.Point(13, 274);
            this.Organizer_Events.Name = "Organizer_Events";
            this.Organizer_Events.Size = new System.Drawing.Size(139, 56);
            this.Organizer_Events.TabIndex = 1;
            this.Organizer_Events.Text = "Total Events by Each Organizer";
            this.Organizer_Events.UseVisualStyleBackColor = true;
            this.Organizer_Events.Click += new System.EventHandler(this.Organizer_Events_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(665, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Managerial Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Popular_Venues_button
            // 
            this.Popular_Venues_button.Location = new System.Drawing.Point(706, 264);
            this.Popular_Venues_button.Name = "Popular_Venues_button";
            this.Popular_Venues_button.Size = new System.Drawing.Size(139, 56);
            this.Popular_Venues_button.TabIndex = 3;
            this.Popular_Venues_button.Text = "Show Most Popular Venues";
            this.Popular_Venues_button.UseVisualStyleBackColor = true;
            this.Popular_Venues_button.Click += new System.EventHandler(this.Popular_Venues_button_Click);
            // 
            // Statstical
            // 
            this.Statstical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Statstical.Location = new System.Drawing.Point(545, 41);
            this.Statstical.Name = "Statstical";
            this.Statstical.RowHeadersWidth = 51;
            this.Statstical.RowTemplate.Height = 24;
            this.Statstical.Size = new System.Drawing.Size(500, 208);
            this.Statstical.TabIndex = 4;
            this.Statstical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Statstical_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Average Feedback Rating for Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Total Revenue By Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Statstical Reports";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Attendance Trends by Month";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(706, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 56);
            this.button4.TabIndex = 9;
            this.button4.Text = "Variance in Ticket Prices Across Events";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 56);
            this.button5.TabIndex = 10;
            this.button5.Text = "Most Profitable Organizer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 56);
            this.button6.TabIndex = 11;
            this.button6.Text = " Profit Gained By Organizer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Managerial);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.Organizer_Events);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 455);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(122, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Managerial Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(680, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Statstical Reports";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(332, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 56);
            this.button7.TabIndex = 13;
            this.button7.Text = "Total Users Registered";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(332, 336);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 56);
            this.button8.TabIndex = 14;
            this.button8.Text = "Total Events By Type";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(868, 338);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 56);
            this.button9.TabIndex = 15;
            this.button9.Text = "Average Feedback Rating";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(868, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 56);
            this.button10.TabIndex = 14;
            this.button10.Text = " Feedback Summary By Event";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Statstics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Statstical);
            this.Controls.Add(this.Popular_Venues_button);
            this.Controls.Add(this.label1);
            this.Name = "Statstics";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Statstics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Managerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statstical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Managerial;
        private System.Windows.Forms.Button Organizer_Events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Popular_Venues_button;
        private System.Windows.Forms.DataGridView Statstical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}