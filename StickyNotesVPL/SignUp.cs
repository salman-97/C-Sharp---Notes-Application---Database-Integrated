using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StickyNotesVPL
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen welScreen = new StartScreen();
            welScreen.Show();
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            string conSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection connectDB = new MySqlConnection(conSTR);

            string fname = fnametxt.Text.ToString();
            string lname = lnametxt.Text.ToString();
            string email = emailtxt.Text.ToString();
            string cont = conttxt.Text.ToString();
            string ctr = countryBox.Text.ToString();
            string uname = unametxt.Text.ToString();
            string upass = passtxt.Text.ToString();
            string gender;
            if (RBmale.Checked == true)
            {
                gender = RBmale.Text.ToString();
            }
            else
            {
                gender = RBfemale.Text.ToString();
            }

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cont)
                || string.IsNullOrEmpty(ctr) || string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upass))
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                connectDB.Open();

                // QUERY 1 // Inserting Data into usersignup table
                string query1 = "Insert into usersignup(FirstName, LastName, Email, Contact, Country, Gender, Username, Password)" +
                    "values('"+fname+"', '"+lname+"', '"+email+"','"+cont+"', '"+ctr+"', '"+gender+"' ,'"+uname+"', '"+upass+"')";

                MySqlCommand cmd1 = new MySqlCommand(query1, connectDB);
                cmd1.ExecuteNonQuery();

                // QUERY 2 // Inserting Username & Password in login table
                string query2 = "Insert into login(UserName, Password) values('"+uname+"', '"+upass+"')";
                MySqlCommand cmd2 = new MySqlCommand(query2, connectDB);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully");
                connectDB.Close();

                MessageBox.Show("Login with Username & Password");
            }
        }
    }
}
