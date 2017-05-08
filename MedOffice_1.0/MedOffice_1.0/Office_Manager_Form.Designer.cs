namespace MedOffice_1._0
{
    partial class Office_Manager_Form
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
            this.components = new System.ComponentModel.Container();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOfficeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOfficeDBDataSet = new MedOffice_1._0.MedOfficeDBDataSet();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.loginsTableAdapter = new MedOffice_1._0.MedOfficeDBDataSetTableAdapters.LoginsTableAdapter();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.DataSource = this.loginsBindingSource;
            this.cboEmployees.DisplayMember = "Username";
            this.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(69, 12);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(173, 21);
            this.cboEmployees.TabIndex = 0;
            this.cboEmployees.ValueMember = "User_ID";
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.medOfficeDBDataSetBindingSource;
            // 
            // medOfficeDBDataSetBindingSource
            // 
            this.medOfficeDBDataSetBindingSource.DataSource = this.medOfficeDBDataSet;
            this.medOfficeDBDataSetBindingSource.Position = 0;
            // 
            // medOfficeDBDataSet
            // 
            this.medOfficeDBDataSet.DataSetName = "MedOfficeDBDataSet";
            this.medOfficeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(7, 15);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // lstSchedule
            // 
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.Location = new System.Drawing.Point(10, 39);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(232, 186);
            this.lstSchedule.TabIndex = 2;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(249, 13);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnViewSchedule.TabIndex = 3;
            this.btnViewSchedule.Text = "View";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // Office_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 227);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.lstSchedule);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cboEmployees);
            this.Name = "Office_Manager_Form";
            this.Text = "Staffing Form";
            this.Load += new System.EventHandler(this.Office_Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.BindingSource medOfficeDBDataSetBindingSource;
        private MedOfficeDBDataSet medOfficeDBDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private MedOfficeDBDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.ListBox lstSchedule;
        private System.Windows.Forms.Button btnViewSchedule;
    }
}