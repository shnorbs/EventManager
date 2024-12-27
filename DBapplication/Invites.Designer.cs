namespace DBapplication
{
    partial class Invites
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
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            this.UserInvitedDataGrid = new System.Windows.Forms.DataGridView();
            this.FirstName_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invite_button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInvitedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Location = new System.Drawing.Point(36, 35);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.Size = new System.Drawing.Size(443, 207);
            this.UserDataGrid.TabIndex = 0;
            // 
            // UserInvitedDataGrid
            // 
            this.UserInvitedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInvitedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName_column,
            this.Last_Name_column,
            this.Email_column,
            this.Phone_Number_column});
            this.UserInvitedDataGrid.Location = new System.Drawing.Point(514, 35);
            this.UserInvitedDataGrid.Name = "UserInvitedDataGrid";
            this.UserInvitedDataGrid.Size = new System.Drawing.Size(443, 207);
            this.UserInvitedDataGrid.TabIndex = 1;
            // 
            // FirstName_column
            // 
            this.FirstName_column.HeaderText = "First_Name";
            this.FirstName_column.Name = "FirstName_column";
            this.FirstName_column.ReadOnly = true;
            // 
            // Last_Name_column
            // 
            this.Last_Name_column.HeaderText = "Last_Name";
            this.Last_Name_column.Name = "Last_Name_column";
            this.Last_Name_column.ReadOnly = true;
            // 
            // Email_column
            // 
            this.Email_column.HeaderText = "Email";
            this.Email_column.Name = "Email_column";
            this.Email_column.ReadOnly = true;
            // 
            // Phone_Number_column
            // 
            this.Phone_Number_column.HeaderText = "Phone_Number";
            this.Phone_Number_column.Name = "Phone_Number_column";
            this.Phone_Number_column.ReadOnly = true;
            // 
            // Invite_button
            // 
            this.Invite_button.Location = new System.Drawing.Point(36, 262);
            this.Invite_button.Name = "Invite_button";
            this.Invite_button.Size = new System.Drawing.Size(114, 46);
            this.Invite_button.TabIndex = 2;
            this.Invite_button.Text = "Invite";
            this.Invite_button.UseVisualStyleBackColor = true;
            this.Invite_button.Click += new System.EventHandler(this.Invite_button_Click);
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(431, 347);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(129, 54);
            this.Done_button.TabIndex = 3;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(514, 262);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(105, 46);
            this.Remove_button.TabIndex = 4;
            this.Remove_button.Text = "Remove From List";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Invites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 576);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.Invite_button);
            this.Controls.Add(this.UserInvitedDataGrid);
            this.Controls.Add(this.UserDataGrid);
            this.Name = "Invites";
            this.Text = "Invites";
            this.Load += new System.EventHandler(this.Invites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInvitedDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataGrid;
        private System.Windows.Forms.DataGridView UserInvitedDataGrid;
        private System.Windows.Forms.Button Invite_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number_column;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Remove_button;
    }
}