using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class Clerical : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbConnection conn2 = new OleDbConnection();
        string patientLast, patientFirst, ins, dob, fullPatient, age, gender, ethnicity, phone, address, allergies, disease, medication, policyHolder;
        string checkin;

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

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            checkin = "yes";

            if (checkinBox.Checked)
            {
                conn2.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn2;
                checkin = "Yes";

                //  SQL command add to database
                comm.CommandText = "UPDATE OurPatients SET CheckedIn=[CheckedIn] +'" + checkin
                    + "'WHERE PatientLast= '" + patientLast + "' and PatientFirst= '" + patientFirst + "'";

                comm.ExecuteNonQuery();

                conn2.Close(); //close connection

                MessageBox.Show(fullPatient + " successfully checked in.");
            }
        }

        private void apptButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ethnicity_Click(object sender, EventArgs e)
        {

        }

        private void textBox_gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

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
            conn2.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn2;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst, PatientAge" 
                + ", PatientDOB, PatientIns, Gender, Ethnicity, PhoneNumber, Address, Allergies, Diseases, Medications)" +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "', '" + age + "','" + dob + "', '"
                     + ins +"','" + gender + "', '"  + ethnicity +"', '"
                     + phone + "','" + address + "','"+ allergies + "', '" + disease + "', '" + medication + "')";

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

            conn2.Close(); //close connection
        }

        private void Clerical_Load(object sender, EventArgs e)
        {
            insBox.Items.Add("Selfpay");
            insBox.Items.Add("Insurance");
        }

        public Clerical()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\GitHub\CST-227-CLC-Project\Med_2.mdb;";
            conn2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\GitHub\CST-227-CLC-Project\Med_2.mdb";
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
