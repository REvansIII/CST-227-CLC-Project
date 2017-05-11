using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Clerical : Form
    {
        //Class level variables
        OleDbConnection conn = new OleDbConnection();
        string patientLast, patientFirst, ins, dob, fullPatient, age, gender, ethnicity, phone;
        string checkin, address, allergies, disease, medication, policyHolder;

        private static Clerical _instance;

        public static Clerical Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Clerical();
                return _instance;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;
            gender = textBox_gender.Text;
            ethnicity = textBox_ethnicity.Text;
            phone = textBox_phoneNumber.Text;
            address = textBox_address.Text;
            allergies = textBox_Allergies_Diseases_Meds.Text;
            disease = textBox_Allergies_Diseases_Meds.Text;
            medication = textBox_Allergies_Diseases_Meds.Text;

            //open connection
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, PatientAge"
                + ", PatientDOB, PatientIns, Gender, Ethnicity, PhoneNumber, Address, Allergies, Diseases, Medications)" +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "', '" + age + "','" + dob + "', '"
                     + ins + "','" + gender + "', '" + ethnicity + "', '"
                     + phone + "','" + address + "','" + allergies + "', '" + disease + "', '" + medication + "')";

            comm.Parameters.AddWithValue("@PatientLast", patientLast);
            comm.Parameters.AddWithValue("@PatientFirst", patientFirst);
            comm.Parameters.AddWithValue("@PatientAge", age);
            comm.Parameters.AddWithValue("@PatientDOB", dob);
            comm.Parameters.AddWithValue("@PatientIns", ins);
            comm.Parameters.AddWithValue("@Gender", gender);
            comm.Parameters.AddWithValue("@Ethnicity", ethnicity);
            comm.Parameters.AddWithValue("@PhoneNumber", phone);
            comm.Parameters.AddWithValue("@Address", address);
            comm.Parameters.AddWithValue("@Allergies", allergies);
            comm.Parameters.AddWithValue("@Diseases", disease);
            comm.Parameters.AddWithValue("@Medications", medication);

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
            conn.ConnectionString = OurConnection.Conn;
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            checkin = "yes";

            if (checkinBox.Checked)
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                checkin = "Yes";

                //  SQL command add to database
                comm.CommandText = "UPDATE OurPatients SET CheckedIn=[CheckedIn] +'" + checkin
                    + "'WHERE PatientLast= '" + patientLast + "' and PatientFirst= '" + patientFirst + "'";

                comm.ExecuteNonQuery();

                conn.Close(); //close connection

                MessageBox.Show(fullPatient + " successfully checked in.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            dob = dobBox.Text;
            ins = insBox.Text;
            age = ageBox.Text;
            gender = textBox_gender.Text;
            ethnicity = textBox_ethnicity.Text;
            phone = textBox_phoneNumber.Text;
            address = textBox_address.Text;
            disease = textBox_Allergies_Diseases_Meds.Text;

            MessageBox.Show("Lastname" + patientLast);

            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM OurPatients WHERE PatientLast= '"
                + patientLast + "' and PatientFirst= '" + patientFirst
                + "'";
            OleDbDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {

                age = (reader["PatientAge"].ToString());
                dob = (reader["PatientDOB"].ToString());
                ins = (reader["PatientIns"].ToString());
                gender = (reader["Gender"].ToString());
                ethnicity = (reader["Ethnicity"].ToString());
                phone = (reader["PhoneNumber"].ToString());
                address = (reader["Address"].ToString());
                allergies = (reader["Allergies"].ToString());
                disease = (reader["Diseases"].ToString());
                medication = (reader["Medications"].ToString());

                fullPatient = (patientLast + ", " + patientFirst + ", " + age);
                MessageBox.Show("" + fullPatient);
                patientBox.Items.Add(fullPatient);
            }

            conn.Close();
        }
    }
}
