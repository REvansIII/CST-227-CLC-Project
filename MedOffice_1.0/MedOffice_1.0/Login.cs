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
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string permission = "";
                
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConnectionString.Conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT PermissionType FROM Logins WHERE Username= '"
                    + username + "' and Password= '" + password + "'";
                OleDbDataReader reader = comm.ExecuteReader();

               while (reader.Read())
                {
                    permission = (reader["PermissionType"].ToString());
                }
                switch (permission)
                {
                    //Clerical login page
                    case "2":
                    Clerical clerk = new Clerical();
                    clerk.Show();
                    break;
                    
                    //TODO add admin page and display page
                    case "1":

                    default:
                        MessageBox.Show("This user has no permissions to access this application.");
                        break;

                }
                conn.Close();
            }
            //Message that is displayed if user is unable to access DB.
            catch (Exception)
            {
                MessageBox.Show("Unable to access DB. Please check your DB connectivity settings.", "Unable to connect to DB",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }  
        }
    }
}
