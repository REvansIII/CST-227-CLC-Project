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
        //Enables forms based on user Permissions passed in
        public Main_Menu(String username, Boolean cForm)
        {
            //Code in this method happens as the application is opened
            InitializeComponent();
            Welcomelbl.Text = "Welcome " + username;
            //Enables the forms the users have access to
            clericalFormToolStripMenuItem.Enabled = cForm;

        }
        //Closes this form
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

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
