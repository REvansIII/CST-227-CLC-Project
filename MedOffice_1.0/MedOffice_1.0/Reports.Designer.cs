﻿namespace MedOffice_1._0
{
    partial class Reports
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
            this.textbox_TestControl = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.Button();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.listBox_TestReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textbox_TestControl
            // 
            this.textbox_TestControl.Location = new System.Drawing.Point(91, 87);
            this.textbox_TestControl.Name = "textbox_TestControl";
            this.textbox_TestControl.Size = new System.Drawing.Size(93, 20);
            this.textbox_TestControl.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(214, 87);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(147, 20);
            this.textBox_LastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(94, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(326, 13);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Please enter the Control code and patient name.";
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(273, 165);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(75, 23);
            this.Main.TabIndex = 4;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(384, 87);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(135, 20);
            this.textBox_FirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(91, 165);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 3;
            this.button_Run.Text = "Run Report";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // listBox_TestReport
            // 
            this.listBox_TestReport.FormattingEnabled = true;
            this.listBox_TestReport.HorizontalExtent = 760;
            this.listBox_TestReport.Location = new System.Drawing.Point(43, 215);
            this.listBox_TestReport.Name = "listBox_TestReport";
            this.listBox_TestReport.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_TestReport.Size = new System.Drawing.Size(808, 160);
            this.listBox_TestReport.TabIndex = 5;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 400);
            this.Controls.Add(this.listBox_TestReport);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textbox_TestControl);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_TestControl;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.ListBox listBox_TestReport;
    }
}