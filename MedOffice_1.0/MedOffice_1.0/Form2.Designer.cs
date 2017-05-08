namespace MedOffice_1._0
{
    partial class InsInfoForm
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
            this.policyBox = new System.Windows.Forms.TextBox();
            this.effDateBox = new System.Windows.Forms.DateTimePicker();
            this.expDateBox = new System.Windows.Forms.DateTimePicker();
            this.insBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insSaveButton = new System.Windows.Forms.Button();
            this.policyHolderBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // policyBox
            // 
            this.policyBox.Location = new System.Drawing.Point(304, 69);
            this.policyBox.Name = "policyBox";
            this.policyBox.Size = new System.Drawing.Size(100, 20);
            this.policyBox.TabIndex = 0;
            // 
            // effDateBox
            // 
            this.effDateBox.Location = new System.Drawing.Point(254, 111);
            this.effDateBox.Name = "effDateBox";
            this.effDateBox.Size = new System.Drawing.Size(200, 20);
            this.effDateBox.TabIndex = 1;
            // 
            // expDateBox
            // 
            this.expDateBox.Location = new System.Drawing.Point(254, 137);
            this.expDateBox.Name = "expDateBox";
            this.expDateBox.Size = new System.Drawing.Size(200, 20);
            this.expDateBox.TabIndex = 2;
            // 
            // insBox
            // 
            this.insBox.Location = new System.Drawing.Point(304, 174);
            this.insBox.Name = "insBox";
            this.insBox.Size = new System.Drawing.Size(100, 20);
            this.insBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Policy Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Effective Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expiration Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insurance Name";
            // 
            // insSaveButton
            // 
            this.insSaveButton.Location = new System.Drawing.Point(317, 200);
            this.insSaveButton.Name = "insSaveButton";
            this.insSaveButton.Size = new System.Drawing.Size(75, 23);
            this.insSaveButton.TabIndex = 8;
            this.insSaveButton.Text = "Save Info";
            this.insSaveButton.UseVisualStyleBackColor = true;
            this.insSaveButton.Click += new System.EventHandler(this.insSaveButton_Click);
            // 
            // policyHolderBox
            // 
            this.policyHolderBox.Location = new System.Drawing.Point(304, 43);
            this.policyHolderBox.Name = "policyHolderBox";
            this.policyHolderBox.Size = new System.Drawing.Size(209, 20);
            this.policyHolderBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Policy Holder (last, first)";
            // 
            // InsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(726, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.policyHolderBox);
            this.Controls.Add(this.insSaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insBox);
            this.Controls.Add(this.expDateBox);
            this.Controls.Add(this.effDateBox);
            this.Controls.Add(this.policyBox);
            this.Name = "InsInfoForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InsInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox policyBox;
        private System.Windows.Forms.DateTimePicker effDateBox;
        private System.Windows.Forms.DateTimePicker expDateBox;
        private System.Windows.Forms.TextBox insBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insSaveButton;
        private System.Windows.Forms.TextBox policyHolderBox;
        private System.Windows.Forms.Label label5;
    }
}