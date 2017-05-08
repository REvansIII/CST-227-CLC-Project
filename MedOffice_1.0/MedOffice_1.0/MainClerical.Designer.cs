namespace MedOffice_1._0
{
    partial class MainClerical
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InsuranceButton = new System.Windows.Forms.Button();
            this.addAppButton = new System.Windows.Forms.Button();
            this.ptInfoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(128, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 521);
            this.panel1.TabIndex = 0;
            // 
            // InsuranceButton
            // 
            this.InsuranceButton.Location = new System.Drawing.Point(12, 60);
            this.InsuranceButton.Name = "InsuranceButton";
            this.InsuranceButton.Size = new System.Drawing.Size(110, 47);
            this.InsuranceButton.TabIndex = 1;
            this.InsuranceButton.Text = "Insurance Info";
            this.InsuranceButton.UseVisualStyleBackColor = true;
            this.InsuranceButton.Click += new System.EventHandler(this.InsuranceButton_Click);
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(12, 113);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(110, 47);
            this.addAppButton.TabIndex = 2;
            this.addAppButton.Text = "Add Appointment";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ptInfoButton
            // 
            this.ptInfoButton.Location = new System.Drawing.Point(12, 166);
            this.ptInfoButton.Name = "ptInfoButton";
            this.ptInfoButton.Size = new System.Drawing.Size(110, 47);
            this.ptInfoButton.TabIndex = 3;
            this.ptInfoButton.Text = "Patient Info";
            this.ptInfoButton.UseVisualStyleBackColor = true;
            this.ptInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome, clerical staff";
            // 
            // MainClerical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(934, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptInfoButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.InsuranceButton);
            this.Controls.Add(this.panel1);
            this.Name = "MainClerical";
            this.Text = "MainClerical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InsuranceButton;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button ptInfoButton;
        private System.Windows.Forms.Label label2;
    }
}