namespace MedOffice_1._0
{
    partial class AppointmentView
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
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.apptButton = new System.Windows.Forms.Button();
            this.apptBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(89, 53);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(200, 20);
            this.startDateBox.TabIndex = 0;
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(376, 53);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(200, 20);
            this.endDateBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // apptButton
            // 
            this.apptButton.Location = new System.Drawing.Point(206, 79);
            this.apptButton.Name = "apptButton";
            this.apptButton.Size = new System.Drawing.Size(120, 23);
            this.apptButton.TabIndex = 3;
            this.apptButton.Text = "Show Appointments";
            this.apptButton.UseVisualStyleBackColor = true;
            this.apptButton.Click += new System.EventHandler(this.apptButton_Click);
            // 
            // apptBox
            // 
            this.apptBox.FormattingEnabled = true;
            this.apptBox.Location = new System.Drawing.Point(160, 118);
            this.apptBox.Name = "apptBox";
            this.apptBox.Size = new System.Drawing.Size(347, 212);
            this.apptBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(332, 79);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(704, 345);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.apptBox);
            this.Controls.Add(this.apptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.startDateBox);
            this.Name = "AppointmentView";
            this.Load += new System.EventHandler(this.AppointmentView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apptButton;
        private System.Windows.Forms.ListBox apptBox;
        private System.Windows.Forms.Button clearButton;
    }
}
