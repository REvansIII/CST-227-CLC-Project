namespace MedOffice_1._0
{
    partial class Clerical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.TextBox();
            this.insBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientBox = new System.Windows.Forms.ListBox();
            this.checkInButton = new System.Windows.Forms.Button();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apptDateBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.apptSave = new System.Windows.Forms.Button();
            this.viewApptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(277, 134);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(382, 134);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Patient";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(117, 108);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(222, 108);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(50, 20);
            this.ageBox.TabIndex = 2;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(277, 108);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(100, 20);
            this.dobBox.TabIndex = 3;
            // 
            // insBox
            // 
            this.insBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insBox.FormattingEnabled = true;
            this.insBox.Location = new System.Drawing.Point(382, 108);
            this.insBox.Name = "insBox";
            this.insBox.Size = new System.Drawing.Size(121, 21);
            this.insBox.TabIndex = 4;
            this.insBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome, clerical staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "D.O.B, mm/dd/yyyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Insurance";
            // 
            // patientBox
            // 
            this.patientBox.FormattingEnabled = true;
            this.patientBox.Location = new System.Drawing.Point(191, 164);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(312, 108);
            this.patientBox.TabIndex = 7;
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(308, 278);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(75, 23);
            this.checkInButton.TabIndex = 8;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(12, 108);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "First Name";
            // 
            // apptDateBox
            // 
            this.apptDateBox.Location = new System.Drawing.Point(509, 108);
            this.apptDateBox.Name = "apptDateBox";
            this.apptDateBox.Size = new System.Drawing.Size(200, 20);
            this.apptDateBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Appointment Date";
            // 
            // apptSave
            // 
            this.apptSave.Location = new System.Drawing.Point(202, 278);
            this.apptSave.Name = "apptSave";
            this.apptSave.Size = new System.Drawing.Size(100, 23);
            this.apptSave.TabIndex = 17;
            this.apptSave.Text = "Add appointment";
            this.apptSave.UseVisualStyleBackColor = true;
            this.apptSave.Click += new System.EventHandler(this.apptSave_Click);
            // 
            // viewApptButton
            // 
            this.viewApptButton.Location = new System.Drawing.Point(389, 278);
            this.viewApptButton.Name = "viewApptButton";
            this.viewApptButton.Size = new System.Drawing.Size(105, 23);
            this.viewApptButton.TabIndex = 18;
            this.viewApptButton.Text = "View Appointments";
            this.viewApptButton.UseVisualStyleBackColor = true;
            this.viewApptButton.Click += new System.EventHandler(this.viewApptButton_Click);
            // 
            // Clerical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(720, 356);
            this.Controls.Add(this.viewApptButton);
            this.Controls.Add(this.apptSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.apptDateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insBox);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Clerical";
            this.Text = "MedOffice_1.0";
            this.Load += new System.EventHandler(this.Clerical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox dobBox;
        private System.Windows.Forms.ComboBox insBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox patientBox;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker apptDateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button apptSave;
        private System.Windows.Forms.Button viewApptButton;
    }
}
