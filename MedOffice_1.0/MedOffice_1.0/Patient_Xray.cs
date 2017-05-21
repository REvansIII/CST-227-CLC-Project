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

namespace MedOffice_1._0
{
    public partial class Patient_Xray : Form
    {
        public Patient_Xray()
        {
            InitializeComponent();
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

        private void Patient_Xray_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medOfficeDB_Test_13MayDataSet.XRay_Types' table. You can move, or remove it, as needed.
            this.xRay_TypesTableAdapter.Fill(this.medOfficeDB_Test_13MayDataSet.XRay_Types);

        }

        //Takes you back to the reports form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Reports nrpt = new Reports();
            nrpt.Show();
            this.Hide();
        }


    }
}
