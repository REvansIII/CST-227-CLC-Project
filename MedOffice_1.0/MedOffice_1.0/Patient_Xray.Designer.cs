namespace MedOffice_1._0
{
    partial class Patient_Xray
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
            this.pboxXRay = new System.Windows.Forms.PictureBox();
            this.txtMemo = new System.Windows.Forms.RichTextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNwq = new System.Windows.Forms.Button();
            this.txtXrayImageLoc = new System.Windows.Forms.TextBox();
            this.lblXRayImage = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblXray = new System.Windows.Forms.Label();
            this.lblXrayID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboXrayTypes = new System.Windows.Forms.ComboBox();
            this.xRayTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medOfficeDB_Test_13MayDataSet = new MedOffice_1._0.MedOfficeDB_Test_13MayDataSet();
            this.lblXrayTitle = new System.Windows.Forms.Label();
            this.txtXrayTitle = new System.Windows.Forms.TextBox();
            this.xRay_TypesTableAdapter = new MedOffice_1._0.MedOfficeDB_Test_13MayDataSetTableAdapters.XRay_TypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pboxXRay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRayTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDB_Test_13MayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxXRay
            // 
            this.pboxXRay.Location = new System.Drawing.Point(233, 12);
            this.pboxXRay.Name = "pboxXRay";
            this.pboxXRay.Size = new System.Drawing.Size(469, 477);
            this.pboxXRay.TabIndex = 0;
            this.pboxXRay.TabStop = false;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(6, 222);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(221, 267);
            this.txtMemo.TabIndex = 1;
            this.txtMemo.Text = "";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(3, 206);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(39, 13);
            this.lblMemo.TabIndex = 2;
            this.lblMemo.Text = "Memo:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNwq
            // 
            this.btnNwq.Location = new System.Drawing.Point(8, 180);
            this.btnNwq.Name = "btnNwq";
            this.btnNwq.Size = new System.Drawing.Size(75, 23);
            this.btnNwq.TabIndex = 4;
            this.btnNwq.Text = "New";
            this.btnNwq.UseVisualStyleBackColor = true;
            // 
            // txtXrayImageLoc
            // 
            this.txtXrayImageLoc.Enabled = false;
            this.txtXrayImageLoc.Location = new System.Drawing.Point(6, 58);
            this.txtXrayImageLoc.Name = "txtXrayImageLoc";
            this.txtXrayImageLoc.Size = new System.Drawing.Size(221, 20);
            this.txtXrayImageLoc.TabIndex = 5;
            // 
            // lblXRayImage
            // 
            this.lblXRayImage.AutoSize = true;
            this.lblXRayImage.Location = new System.Drawing.Point(9, 42);
            this.lblXRayImage.Name = "lblXRayImage";
            this.lblXRayImage.Size = new System.Drawing.Size(110, 13);
            this.lblXRayImage.TabIndex = 6;
            this.lblXRayImage.Text = "X-ray Image Location:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(152, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblXray
            // 
            this.lblXray.AutoSize = true;
            this.lblXray.Location = new System.Drawing.Point(9, 12);
            this.lblXray.Name = "lblXray";
            this.lblXray.Size = new System.Drawing.Size(50, 13);
            this.lblXray.TabIndex = 8;
            this.lblXray.Text = "XRay ID:";
            // 
            // lblXrayID
            // 
            this.lblXrayID.AutoSize = true;
            this.lblXrayID.Location = new System.Drawing.Point(65, 12);
            this.lblXrayID.Name = "lblXrayID";
            this.lblXrayID.Size = new System.Drawing.Size(18, 13);
            this.lblXrayID.TabIndex = 9;
            this.lblXrayID.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X-ray Type:";
            // 
            // cboXrayTypes
            // 
            this.cboXrayTypes.DataSource = this.xRayTypesBindingSource;
            this.cboXrayTypes.DisplayMember = "XRay_Type";
            this.cboXrayTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXrayTypes.FormattingEnabled = true;
            this.cboXrayTypes.Location = new System.Drawing.Point(6, 124);
            this.cboXrayTypes.Name = "cboXrayTypes";
            this.cboXrayTypes.Size = new System.Drawing.Size(221, 21);
            this.cboXrayTypes.TabIndex = 12;
            this.cboXrayTypes.ValueMember = "XRay_Type_ID";
            // 
            // xRayTypesBindingSource
            // 
            this.xRayTypesBindingSource.DataMember = "XRay_Types";
            this.xRayTypesBindingSource.DataSource = this.medOfficeDB_Test_13MayDataSet;
            // 
            // medOfficeDB_Test_13MayDataSet
            // 
            this.medOfficeDB_Test_13MayDataSet.DataSetName = "MedOfficeDB_Test_13MayDataSet";
            this.medOfficeDB_Test_13MayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblXrayTitle
            // 
            this.lblXrayTitle.AutoSize = true;
            this.lblXrayTitle.Location = new System.Drawing.Point(89, 12);
            this.lblXrayTitle.Name = "lblXrayTitle";
            this.lblXrayTitle.Size = new System.Drawing.Size(33, 13);
            this.lblXrayTitle.TabIndex = 13;
            this.lblXrayTitle.Text = "Title: ";
            // 
            // txtXrayTitle
            // 
            this.txtXrayTitle.Location = new System.Drawing.Point(118, 9);
            this.txtXrayTitle.Name = "txtXrayTitle";
            this.txtXrayTitle.ReadOnly = true;
            this.txtXrayTitle.Size = new System.Drawing.Size(109, 20);
            this.txtXrayTitle.TabIndex = 14;
            // 
            // xRay_TypesTableAdapter
            // 
            this.xRay_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // Patient_Xray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 509);
            this.Controls.Add(this.txtXrayTitle);
            this.Controls.Add(this.lblXrayTitle);
            this.Controls.Add(this.cboXrayTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblXrayID);
            this.Controls.Add(this.lblXray);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblXRayImage);
            this.Controls.Add(this.txtXrayImageLoc);
            this.Controls.Add(this.btnNwq);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.pboxXRay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Xray";
            this.Text = "Patient_Xray";
            this.Load += new System.EventHandler(this.Patient_Xray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxXRay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRayTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medOfficeDB_Test_13MayDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxXRay;
        private System.Windows.Forms.RichTextBox txtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNwq;
        private System.Windows.Forms.TextBox txtXrayImageLoc;
        private System.Windows.Forms.Label lblXRayImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblXray;
        private System.Windows.Forms.Label lblXrayID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboXrayTypes;
        private System.Windows.Forms.Label lblXrayTitle;
        private System.Windows.Forms.TextBox txtXrayTitle;
        private MedOfficeDB_Test_13MayDataSet medOfficeDB_Test_13MayDataSet;
        private System.Windows.Forms.BindingSource xRayTypesBindingSource;
        private MedOfficeDB_Test_13MayDataSetTableAdapters.XRay_TypesTableAdapter xRay_TypesTableAdapter;
    }
}