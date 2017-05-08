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
    public partial class MainClerical : Form
    {
        public MainClerical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Clerical.Instance))
            {
                panel1.Controls.Add(Clerical.Instance);
                Clerical.Instance.Dock = DockStyle.Fill;
                Clerical.Instance.BringToFront();
            }
            else
                Clerical.Instance.BringToFront();
        }

        private void InsuranceButton_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(InsInfoForm.Instance))
            {
                panel1.Controls.Add(InsInfoForm.Instance);
                InsInfoForm.Instance.Dock = DockStyle.Fill;
                InsInfoForm.Instance.BringToFront();
            }
            else
                InsInfoForm.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(AddAppointment.Instance))
            {
                panel1.Controls.Add(AddAppointment.Instance);
                AddAppointment.Instance.Dock = DockStyle.Fill;
                AddAppointment.Instance.BringToFront();
            }
            else
                AddAppointment.Instance.BringToFront();
        }
    
    }
}
