namespace Login {
    partial class EmployeeManagement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.employeeListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEnded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.empPictureBox = new System.Windows.Forms.PictureBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeListView
            // 
            this.employeeListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.employeeLastName,
            this.employeeFirstName,
            this.employeeJob,
            this.dateStarted,
            this.dateEnded});
            this.employeeListView.FullRowSelect = true;
            this.employeeListView.GridLines = true;
            this.employeeListView.HideSelection = false;
            this.employeeListView.HoverSelection = true;
            this.employeeListView.Location = new System.Drawing.Point(21, 330);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeeListView.Size = new System.Drawing.Size(553, 195);
            this.employeeListView.TabIndex = 0;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.employeeListView_MouseClick);
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeLastName
            // 
            this.employeeLastName.Text = "Last Name";
            this.employeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.employeeLastName.Width = 77;
            // 
            // employeeFirstName
            // 
            this.employeeFirstName.Text = "First Name";
            this.employeeFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.employeeFirstName.Width = 116;
            // 
            // employeeJob
            // 
            this.employeeJob.Text = "Job Title";
            this.employeeJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.employeeJob.Width = 116;
            // 
            // dateStarted
            // 
            this.dateStarted.Text = "Start Date";
            this.dateStarted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dateStarted.Width = 89;
            // 
            // dateEnded
            // 
            this.dateEnded.Text = "End Date";
            this.dateEnded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dateEnded.Width = 89;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(181, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(236, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(181, 100);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(181, 136);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(236, 20);
            this.jobTextBox.TabIndex = 4;
            this.jobTextBox.TextChanged += new System.EventHandler(this.jobTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(98, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastNameLabel.Location = new System.Drawing.Point(47, 64);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameLabel.Location = new System.Drawing.Point(47, 103);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name:";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jobTitleLabel.Location = new System.Drawing.Point(61, 139);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(66, 17);
            this.jobTitleLabel.TabIndex = 9;
            this.jobTitleLabel.Text = "Job Title:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startDateLabel.Location = new System.Drawing.Point(51, 174);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(76, 17);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Start Date:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(628, 330);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 47);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editButton.Location = new System.Drawing.Point(628, 406);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 47);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "&Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteButton.Location = new System.Drawing.Point(628, 478);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 47);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(181, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(54, 211);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 16);
            this.endDateLabel.TabIndex = 15;
            this.endDateLabel.Text = "End Date:";
            // 
            // empPictureBox
            // 
            this.empPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empPictureBox.Location = new System.Drawing.Point(488, 21);
            this.empPictureBox.Name = "empPictureBox";
            this.empPictureBox.Size = new System.Drawing.Size(279, 205);
            this.empPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empPictureBox.TabIndex = 16;
            this.empPictureBox.TabStop = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startDatePicker.CustomFormat = "MM/dd/yyyy";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(181, 174);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(236, 20);
            this.startDatePicker.TabIndex = 17;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "MM/dd/yyyy";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(181, 206);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(236, 20);
            this.endDatePicker.TabIndex = 18;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 541);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.empPictureBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.employeeListView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader employeeLastName;
        private System.Windows.Forms.ColumnHeader employeeFirstName;
        private System.Windows.Forms.ColumnHeader employeeJob;
        private System.Windows.Forms.ColumnHeader dateStarted;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader dateEnded;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.PictureBox empPictureBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
    }
}