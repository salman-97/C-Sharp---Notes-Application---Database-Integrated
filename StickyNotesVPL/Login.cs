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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen welScreen = new StartScreen();
            welScreen.Show();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string conSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection connectDB = new MySqlConnection(conSTR);

            string uname = unametxt.Text.ToString();
            string upass = upasstxt.Text.ToString();

            if(string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upass))
            {
                MessageBox.Show("No empty fields allowed");
            }
            else
            {
                try
                {
                    connectDB.Open();
                    MySqlCommand cmd = new MySqlCommand("Select * from login",connectDB);
                    MySqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        if(uname == read.GetString("UserName") && upass == read.GetString("Password"))
                        {
                            MessageBox.Show(uname + " " + "successfully login. WELCOME :)");
                            
                            // Passing username to next Screen in Constructor
                            getusername.Text = read["UserName"].ToString();
                            MainScreen main = new MainScreen(getusername);
                            //MainScreen main = new MainScreen();
                            this.Hide();
                            main.Show();
                            return;
                        }
                    }
                    read.Close();
                    connectDB.Close();

                }
                catch (Exception ex)
                {
                    connectDB.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                { 
                    connectDB.Close(); 
                }
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
