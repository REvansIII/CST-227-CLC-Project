using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedOffice_1._0
{
    public partial class Main_Menu : Form
    {
        //Enables forms based 
        public Main_Menu(Boolean cForm)
        {
            //Code in this method happens as the application is opened
            InitializeComponent();
            //Enables the forms the users have access to
            clericalFormToolStripMenuItem.Enabled = cForm;
        }
        //Closes application
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clericalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clerical nClerical = new Clerical();
            //Opens nClerical form in the MDI container
            nClerical.MdiParent = this;
            nClerical.Show();
        }

        private void testResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        //Print button under file
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Brings up Print dialog to print application screen
            PrintDialog nPD = new PrintDialog();
            nPD.ShowDialog();
        }
    }
}
