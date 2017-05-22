namespace MedOffice_1._0
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textbox_TestControl = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.Button();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboXrayImages = new System.Windows.Forms.ComboBox();
            this.btnOpenXray = new System.Windows.Forms.Button();
            this.btnCreateXray = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.medOfficeDB_Test_13MayDataSet = new MedOffice_1._0.MedOfficeDB_Test_13MayDataSet();
            this.patientXraysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_XraysTableAdapter = new MedOffice_1._0.MedOfficeDB_Test_13MayDataSetTableAdapters.Patient_XraysTableAdapter();
            this.listBox_TestResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDB_Test_13MayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientXraysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_TestControl
            // 
            this.textbox_TestControl.Location = new System.Drawing.Point(12, 122);
            this.textbox_TestControl.Name = "textbox_TestControl";
            this.textbox_TestControl.Size = new System.Drawing.Size(135, 20);
            this.textbox_TestControl.TabIndex = 2;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(12, 82);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(135, 20);
            this.textBox_LastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(49, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 13);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Please enter the Control code and patient name.";
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(244, 43);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(75, 23);
            this.Main.TabIndex = 6;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(12, 43);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(135, 20);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(163, 43);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 5;
            this.button_Run.Text = "Run Report";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select existing x-ray to view";
            // 
            // cboXrayImages
            // 
            this.cboXrayImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXrayImages.FormattingEnabled = true;
            this.cboXrayImages.Location = new System.Drawing.Point(163, 89);
            this.cboXrayImages.Name = "cboXrayImages";
            this.cboXrayImages.Size = new System.Drawing.Size(156, 21);
            this.cboXrayImages.TabIndex = 7;
            // 
            // btnOpenXray
            // 
            this.btnOpenXray.Location = new System.Drawing.Point(163, 119);
            this.btnOpenXray.Name = "btnOpenXray";
            this.btnOpenXray.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXray.TabIndex = 8;
            this.btnOpenXray.Text = "Open Xray";
            this.btnOpenXray.UseVisualStyleBackColor = true;
            this.btnOpenXray.Click += new System.EventHandler(this.btnOpenXray_Click);
            // 
            // btnCreateXray
            // 
            this.btnCreateXray.Location = new System.Drawing.Point(244, 119);
            this.btnCreateXray.Name = "btnCreateXray";
            this.btnCreateXray.Size = new System.Drawing.Size(75, 23);
            this.btnCreateXray.TabIndex = 9;
            this.btnCreateXray.Text = "New Xray";
            this.btnCreateXray.UseVisualStyleBackColor = true;
            this.btnCreateXray.Click += new System.EventHandler(this.btnCreateXray_Click);
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Glucose Test";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Blood Test";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Stool Sample";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(307, 213);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // medOfficeDB_Test_13MayDataSet
            // 
            this.medOfficeDB_Test_13MayDataSet.DataSetName = "MedOfficeDB_Test_13MayDataSet";
            this.medOfficeDB_Test_13MayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientXraysBindingSource
            // 
            this.patientXraysBindingSource.DataMember = "Patient_Xrays";
            this.patientXraysBindingSource.DataSource = this.medOfficeDB_Test_13MayDataSet;
            // 
            // patient_XraysTableAdapter
            // 
            this.patient_XraysTableAdapter.ClearBeforeFill = true;
            // 
            // listBox_TestResults
            // 
            this.listBox_TestResults.FormattingEnabled = true;
            this.listBox_TestResults.Location = new System.Drawing.Point(325, 119);
            this.listBox_TestResults.Name = "listBox_TestResults";
            this.listBox_TestResults.Size = new System.Drawing.Size(401, 316);
            this.listBox_TestResults.TabIndex = 15;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 514);
            this.Controls.Add(this.listBox_TestResults);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCreateXray);
            this.Controls.Add(this.btnOpenXray);
            this.Controls.Add(this.cboXrayImages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textbox_TestControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDB_Test_13MayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientXraysBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboXrayImages;
        private System.Windows.Forms.Button btnOpenXray;
        private System.Windows.Forms.Button btnCreateXray;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MedOfficeDB_Test_13MayDataSet medOfficeDB_Test_13MayDataSet;
        private System.Windows.Forms.BindingSource patientXraysBindingSource;
        private MedOfficeDB_Test_13MayDataSetTableAdapters.Patient_XraysTableAdapter patient_XraysTableAdapter;
        private System.Windows.Forms.ListBox listBox_TestResults;
    }
}