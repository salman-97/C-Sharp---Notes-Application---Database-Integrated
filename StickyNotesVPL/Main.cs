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
    public partial class MainScreen : Form
    {
        public MainScreen(Label getusername)
        {
            InitializeComponent();
            
            fetchusername.Text = getusername.Text + " " +"(logged in)";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen logout = new StartScreen();
            logout.Show();

        }

        private void clearTxTBTB_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void clearFields()
        {
            noteTypetxt.Text = string.Empty;
            noteTitletxt.Text = string.Empty;
            notesTxT.Text = string.Empty;
        }

        private void saveNoteBTN_Click(object sender, EventArgs e)
        {
            string connect = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection DBconnect = new MySqlConnection(connect);

            string noteType = noteTypetxt.Text.ToString();
            string noteTitle = noteTitletxt.Text.ToString();
            string notess = notesTxT.Text.ToString();

            if(string.IsNullOrEmpty(noteType) || string.IsNullOrEmpty(noteTitle) || string.IsNullOrEmpty(notess))
            {
                MessageBox.Show("Fill all fields to SAVE a note !");
            }
            else
            {
                DBconnect.Open();
                string insertQuery = "INSERT into notes(Note_Type, Note_Title, Notes) values('"+noteType+"', '"+noteTitle+"', '"+notess+"')";
                MySqlCommand cmd = new MySqlCommand(insertQuery, DBconnect);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Note successfully SAVED :) ");
                clearFields();
                DBconnect.Close();
            }
        }

        private void viewNotesBTN_Click(object sender, EventArgs e)
        {
            ViewNotes view = new ViewNotes();
            view.Show();
        }

        private void logoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            StartScreen mainPage = new StartScreen();
            mainPage.Show();
        }
    }
}
