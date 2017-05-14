using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Clerical : Form
    {
        OleDbConnection conn = new OleDbConnection();
        //OleDbConnection conn2 = new OleDbConnection();
        public string patientLast, patientFirst, ins, dob, fullPatient, age;

        private void saveButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;

            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, PatientAge" 
                + ", PatientDOB, PatientIns)" +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "', '" + age + "', '" + dob + "', '"
                     + ins + "')";
            comm.Parameters.AddWithValue("@PatientLast", patientLast);
            comm.Parameters.AddWithValue("@PatientFirst", patientFirst);
            comm.Parameters.AddWithValue("@PatientAge", age);
            comm.Parameters.AddWithValue("@PatientDOB", dob);
            comm.Parameters.AddWithValue("@PatientIns", ins);

            comm.ExecuteNonQuery();

            conn.Close();
        }

        private void Clerical_Load(object sender, EventArgs e)
        {
            insBox.Items.Add("Selfpay");
            insBox.Items.Add("Insurance");
        }

        public Clerical()
        {
            InitializeComponent();
            conn.ConnectionString = ConnectionString.Conn;
            //conn2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xdark\Documents\MedOfficeDB.accdb;
//Persist Security Info=False;";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;

            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                + patientLast + "' and PatientFirst= '" + patientFirst
                + "'";
            OleDbDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                patientLast = (reader["PatientLast"].ToString());
                patientFirst = (reader["PatientFirst"].ToString());
                age = (reader["PatientAge"].ToString());
                dob = (reader["PatientDOB"].ToString());
                ins = (reader["PatientIns"].ToString());
                fullPatient = ("" + patientLast + "," + patientFirst + " age " 
                    + age + " " + dob + " " + ins);
                patientBox.Items.Add(fullPatient);
            }
            
            conn.Close();
        }
    }
}
