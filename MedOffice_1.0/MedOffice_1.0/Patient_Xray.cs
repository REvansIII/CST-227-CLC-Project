using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Patient_Xray : Form
    {
        //Class level variables
        OleDbConnection conn = new OleDbConnection(OurConnection.Conn);
        String PatientNum = "";
        int xRayTypeID = 0;

        public Patient_Xray(String PatientNum)
        {
            InitializeComponent();
            this.PatientNum = PatientNum;
        }

        public Patient_Xray(String XrayID, String PatientNum)
        {
            InitializeComponent();
            //Assigns the lblXrayID the XrayID passed into this form from the Reports form
            lblXrayID.Text = XrayID;
            this.PatientNum = PatientNum;
            GetPatientXray(PatientNum, XrayID);
            //Displays image in picturebox and sets stretchImage SizeMode
            pboxXRay.Image = Image.FromFile(txtXrayImageLoc.Text);
            pboxXRay.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /*Browse for file on machine to add to txtXrayImageLoc.text field and displays image in picturebox or displays 
        appropriate error */
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Pulls selected file on machine location into the txtXrayImageLoc.text field
                txtXrayImageLoc.Text = ofd.FileName;
            }
            try
            {
                //Assigns image location looked up into the picturebox
                pboxXRay.Image = Image.FromFile(txtXrayImageLoc.Text);
                //Autosizes image to fit in picturebox
                pboxXRay.SizeMode = PictureBoxSizeMode.StretchImage;
                //Error just in case we cannot load image
            }catch(Exception ex){
                MessageBox.Show("failed to load image. Please try another image. " + ex);
            }
        }

        //Sets and loads initial index of the XRayTypeID in the cboXrayTypes combobox
        private void Patient_Xray_Load(object sender, EventArgs e)
        {
            this.xRay_TypesTableAdapter.Fill(this.medOfficeDB_Test_13MayDataSet.XRay_Types);
            cboXrayTypes.SelectedIndex = xRayTypeID;

        }

        //Takes you back to the reports form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Reports nrpt = new Reports();
            nrpt.Show();
            this.Hide();
        }

        //Save all of the current fields to the Patient_Xrays table
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEmpty() != true)
            {
                if (lblXrayID.Text.Equals("ID"))
                {
                    CreateNewPatientXray(PatientNum);
                }
                else
                {
                    UpdatePatientXray();
                }
            }
        }
        
        // This method fills all of the form fields based on an existing Patient_Xrays record
        private void GetPatientXray(String PatientNumber, String XrayID)
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand()
                {
                    Connection = conn,
                    CommandText = "Select * FROM Patient_Xrays WHERE Patient_ID = " + PatientNumber + " AND XRay_ID = " + XrayID
                };

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    xRayTypeID = int.Parse((reader["XRay_Type_ID"].ToString())) - 1;
                    txtXrayImageLoc.Text = (reader["LocationOfImage"].ToString());
                    txtMemo.Text = (reader["Memo"].ToString());
                    txtXrayTitle.Text = (reader["Xray_Title"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot pull up patient Xray record. Please check DB settings. " + ex);
            }

            //Closes DB connection
            conn.Close();
        }

        //This method creates a new Patient_Xrays record
        private void CreateNewPatientXray(String PatientNumber)
        {
          try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;

                comm.CommandText = "INSERT INTO Patient_Xrays ([Patient_ID],[XRay_Type_ID],[DateOfImage]," +
              "[LocationOfImage],[Memo],[Xray_Title])" +
              "VALUES(@Patient_ID, @XRay_Type_ID, @DateOfImage, @LocationOfImage, @Memo, @XRay_Title)";

            comm.Parameters.Add(new OleDbParameter("@Patient_ID", int.Parse(PatientNum)));
            comm.Parameters.Add(new OleDbParameter("@XRay_Type_ID", int.Parse(cboXrayTypes.SelectedValue.ToString())));
            comm.Parameters.Add(new OleDbParameter("@DateOfImage", DateTime.Now.ToString("MM/dd/yyyy")));
            comm.Parameters.Add(new OleDbParameter("@LocationOfImage", txtXrayImageLoc.Text));
            comm.Parameters.Add(new OleDbParameter("@Memo", txtMemo.Text));
            comm.Parameters.Add(new OleDbParameter("@XRay_Title", txtXrayTitle.Text));
            comm.ExecuteNonQuery();
            //Returns the last identity field saved in the DB
            comm.CommandText = "Select @@Identity";
            lblXrayID.Text = comm.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Xray to Patient_Xrays table. Please check DB connectivity settings. " + ex);
            }

            //Closes DB connection
            conn.Close();
        }
        
        //Update Existing record
        private void UpdatePatientXray()
        {
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = @"UPDATE [Patient_Xrays] "  +
                "SET [XRay_Type_ID] = @XRay_Type_ID, [DateOfImage] = @DateOfImage, [LocationOfImage] = @LocationOfImage, " +
                "[Memo] = @Memo, [XRay_Title] = @XRay_Title " +
                "WHERE [Patient_ID] = @Patient_ID AND [Xray_ID] = @Xray_ID";

                comm.Parameters.Add(new OleDbParameter("@XRay_Type_ID", int.Parse(cboXrayTypes.SelectedValue.ToString())));
                comm.Parameters.Add(new OleDbParameter("@DateOfImage", DateTime.Now.ToString("MM/dd/yyyy")));
                comm.Parameters.Add(new OleDbParameter("@LocationOfImage", txtXrayImageLoc.Text));
                comm.Parameters.Add(new OleDbParameter("@Memo", txtMemo.Text));
                comm.Parameters.Add(new OleDbParameter("@XRay_Title", txtXrayTitle.Text));
                comm.Parameters.Add(new OleDbParameter("@Patient_ID", int.Parse(PatientNum)));
                comm.Parameters.Add(new OleDbParameter("@Xray_ID", int.Parse(lblXrayID.Text)));

                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update Xray in Patient_Xrays table. Please check DB connectivity settings. " + ex);
            }

            //Closes DB connection
            conn.Close();
        }

        //Clears all fields so that the user can create a new Patient Xray record
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblXrayID.Text = "ID";
            txtXrayImageLoc.Text = "";
            txtXrayTitle.Text = "";
            txtMemo.Text = "";
            pboxXRay.Image = Image.FromFile("");
        }
        
        //Displays error message if any of the fields are left blank when the user is trying to save
        private Boolean isEmpty()
        {
            //Checks that all fields have data
            if (txtMemo.Text == "" || txtXrayImageLoc.Text == "" || txtXrayTitle.Text == "" || cboXrayTypes.SelectedIndex == -1){
                MessageBox.Show("Please ensure that all fields are filled out in the form");
                return true;
            }else{
                return false;
            }
        }
    }
}
