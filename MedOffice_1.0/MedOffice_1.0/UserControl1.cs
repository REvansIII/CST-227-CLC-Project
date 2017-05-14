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

        private void updateMed_Click(object sender, EventArgs e)
        {
            patientLast = lastNameBox.Text;
            patientFirst = firstNameBox.Text;
            allMedDis = medListbox.Text;
            string tempAll = "";
            disease = medListbox.Text;
            medication = medListbox.Text;
            List<string> allArr = new List<string>();

            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            for (int i = 0; i < medListbox.Items.Count; i++)
            {
                medListbox.SetSelected(i, true);
                allArr.Add(medListbox.SelectedItem.ToString());
            }
            for (int j = 0; j < allArr.Count; j++)
            {
                if (allMedDis == "")
                {
                    allMedDis = (allArr[j].ToString());
                    tempAll = allMedDis;
                }
                else if (allMedDis != "")
                {
                    allMedDis = (tempAll + ", " + allArr[j].ToString());
                    tempAll = allMedDis;
                }
            }
            if (allergyRadio.Checked)
            {
                conn.Open();
                comm.CommandText = "UPDATE OurPatients SET [Allergies]= '"
                    + allMedDis + "' WHERE PatientLast= '" + patientLast + "' and PatientFirst= '"
                    + patientFirst + "'";
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else if (diseaseRadio.Checked)
            {
                conn.Open();
                comm.CommandText = "UPDATE OurPatients SET [Diseases]= '"
                    + allMedDis + "' WHERE PatientLast= '" + patientLast + "' and PatientFirst= '"
                    + patientFirst + "'";
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else if (medicationRadio.Checked)
            {
                conn.Open();
                comm.CommandText = "UPDATE OurPatients SET [Medications]= '"
                    + allMedDis + "' WHERE PatientLast= '" + patientLast + "' and PatientFirst= '"
                    + patientFirst + "'";
                comm.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addMedButton_Click(object sender, EventArgs e)
        {
            medListbox.Items.Add(textBox_Allergies_Diseases_Meds.Text);
            textBox_Allergies_Diseases_Meds.Clear();
        }

        private void allergyRadio_CheckedChanged(object sender, EventArgs e)
        {
            medListbox.Items.Clear();
        }

        private void diseaseRadio_CheckedChanged(object sender, EventArgs e)
        {
            medListbox.Items.Clear();
        }

        private void medicationRadio_CheckedChanged(object sender, EventArgs e)
        {
            medListbox.Items.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string selectedItem = medListbox.SelectedItem.ToString();
            medListbox.Items.Remove(selectedItem);
        }

        string checkin, address, allMedDis, disease, medication, policyHolder;

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

            //open connection
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO OurPatients(PatientLast, PatientFirst)" 
                /*, PatientAge"
                + ", PatientDOB, PatientIns, Gender, Ethnicity, PhoneNumber, Address)"*/ +
                     "VALUES ('" + patientLast + "', '" + patientFirst
                     + "')";/*, '" + age + "','" + dob + "', '"
                     + ins + "','" + gender + "', '" + ethnicity + "', '"
                     + phone + "','" + address + "')";*/

            comm.Parameters.AddWithValue("@PatientLast", patientLast);
            comm.Parameters.AddWithValue("@PatientFirst", patientFirst);/*
            comm.Parameters.AddWithValue("@PatientAge", age);
            comm.Parameters.AddWithValue("@PatientDOB", dob);
            comm.Parameters.AddWithValue("@PatientIns", ins);
            comm.Parameters.AddWithValue("@Gender", gender);
            comm.Parameters.AddWithValue("@Ethnicity", ethnicity);
            comm.Parameters.AddWithValue("@PhoneNumber", phone);
            comm.Parameters.AddWithValue("@Address", address);*/

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
            Size = new Size(800,600);
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
            
            try
            {
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

                    fullPatient = (patientLast + ", " + patientFirst + ", " + age);
                    MessageBox.Show("" + fullPatient);
                    patientBox.Items.Add(fullPatient);
                }

                conn.Close();
            }
            catch (Exception)
            {
            MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
