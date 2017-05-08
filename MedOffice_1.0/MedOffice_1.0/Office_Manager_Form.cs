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
    public partial class Office_Manager_Form : Form
    {
        public Office_Manager_Form()
        {
            InitializeComponent();
        }

        private void Office_Manager_Form_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'medOfficeDBDataSet.Logins' table.
            this.loginsTableAdapter.Fill(this.medOfficeDBDataSet.Logins);

        }

    }
}
