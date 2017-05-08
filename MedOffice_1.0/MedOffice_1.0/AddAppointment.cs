using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class AddAppointment : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string patientLast, patientFirst, apptDate, apptTime, age, apptType;
        public AddAppointment()
        {
            conn.ConnectionString = ConnectionString.Conn;
            InitializeComponent();
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

            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

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

            conn.Close();

            MessageBox.Show("Appointment created successfully.");
        }

        private void AddApointment_Load(object sender, EventArgs e)
        {
        
        }
    }
    }
