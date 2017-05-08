using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public partial class InsInfoForm : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        string policyHolder, policyNum, effDate, expDate, insCom;

        private void InsInfoForm_Load(object sender, EventArgs e)
        {

        }

        private static InsInfoForm _instance;
        public static InsInfoForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InsInfoForm();
                return _instance;
            }
        }

        public InsInfoForm()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\GitHub\CST-227-CLC-Project\Med_2.mdb;";
        }

        private void insSaveButton_Click(object sender, EventArgs e)
        {
            policyHolder = policyHolderBox.Text;
            policyNum = policyBox.Text;
            effDate = effDateBox.Text;
            expDate = expDateBox.Text;
            insCom = insBox.Text;

            //open connection
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;

            //  SQL command add to database
            comm.CommandText = "INSERT INTO InsuranceInfo"
                + "(PolicyHolder, EffectiveDate, Expiration, PolicyNumber, InsuranceCo) VALUES('" + policyHolder + "', '" + effDate
                + "','" + expDate + "','" + policyNum + "','" + insCom + "')";

            comm.Parameters.AddWithValue("@PolicyHolder", policyHolder);
            comm.Parameters.AddWithValue("@EffectiveDate", effDate);
            comm.Parameters.AddWithValue("@Expiration", expDate);
            comm.Parameters.AddWithValue("@PolicyNum", policyNum);
            comm.Parameters.AddWithValue("@InsuranceCo", insCom);
            comm.ExecuteNonQuery();

            conn.Close(); //close connection

            policyHolderBox.Text = "";
            policyBox.Text = "";
            effDateBox.Text = "";
            expDateBox.Text = "";
            insBox.Text = "";
            MessageBox.Show("Insurance Info Added.");
        }
    }
}
