using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MedOffice_1._0
{
    public partial class Reports : Form
    {
        OleDbConnection conn = new OleDbConnection();

        public string patientLast, patientFirst, Test_Control, TestResults;
        public string GlucoseTest, BloodTest, StoolSample, XRay, PhysicalHealth;

       

        private void button_Run_Click(object sender, EventArgs e)
        {
            Test_Control = textbox_TestControl.Text;
            patientLast = textBox_LastName.Text;
            patientFirst = textBox_FirstName.Text;


            conn.Open();
            OleDbCommand comm = new OleDbCommand()
            {
                Connection = conn,


                CommandText = "SELECT * FROM TestResults WHERE Test_Control= '"
               + textbox_TestControl.Text + "'and Last_Name= '" + textBox_LastName.Text + "'and First_Name='" + textBox_FirstName.Text
               + "'"
            };

            OleDbDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                Test_Control = (reader["Test_Control"].ToString());
                patientLast = (reader["Last_Name"].ToString());
                patientFirst = (reader["First_Name"].ToString());
                GlucoseTest = (reader["Glucose_Test"].ToString());
                BloodTest = (reader["Blood_Test"].ToString());
                StoolSample = (reader["Stool_Sample"].ToString());
                XRay = (reader["X_Ray_Result"].ToString());
                PhysicalHealth = (reader["Physical_Health"].ToString());


                TestResults = (patientLast + "," + patientFirst + "/"+" Glucose Test:" + GlucoseTest + "/" +" Blood Test:"+
                    BloodTest + "/ "+ " Stool Sample:"+ StoolSample + "/ "+" X-Ray Results:" + XRay + "/"+ " Physical Health:" + PhysicalHealth +
                    "/" + " Test Control Code:" + Test_Control);

                listBox_TestReport.Items.Add(TestResults);
            }

            conn.Close();


        }

        private void TestReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
             


        private void Main_Click(object sender, EventArgs e)
        {
            Clerical nClerical = new Clerical();
            nClerical.Show();
            this.Hide();
        }



        public Reports()
        {
            InitializeComponent();
            conn.ConnectionString = ConnectionString.Conn;
        }


       

    }
}    