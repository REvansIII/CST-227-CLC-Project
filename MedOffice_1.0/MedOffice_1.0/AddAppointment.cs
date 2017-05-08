using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class AddAppointment : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbConnection conn2 = new OleDbConnection();

        string patientLast, patientFirst, apptDate, apptTime, age, apptType;

        public AddAppointment()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\GitHub\CST-227-CLC-Project\Med_2.mdb;";
            conn2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\GitHub\CST-227-CLC-Project\Med_2.mdb";
        }

        private static AddAppointment _instance;
        public static AddAppointment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddAppointment();
                return _instance;
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            apptBox.Items.Add("New Patient");
            apptBox.Items.Add("Return Patient");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            apptDate = dateBox.Text;
            apptTime = timeBox.Text;
            age = ageBox.Text;
            apptType = apptBox.Text;

            conn2.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn2;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, AppointmentDate"
                + ", AppointmentTime, PatientAge, AppointmentType)" +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "', '" + apptDate + "', '" + apptTime + "', '" + age + "','" + apptType + "')";

            comm.Parameters.AddWithValue("@PatientLast", patientLast);
            comm.Parameters.AddWithValue("@PatientFirst", patientFirst);
            comm.Parameters.AddWithValue("@AppointmentDate", apptDate);
            comm.Parameters.AddWithValue("@AppointmentTime", apptTime);
            comm.Parameters.AddWithValue("@PatientAge", age);
            comm.Parameters.AddWithValue("@AppointmentType", apptType);

            comm.ExecuteNonQuery();

            conn2.Close();

            MessageBox.Show("Appointment created successfully.");
        }
    }
}
