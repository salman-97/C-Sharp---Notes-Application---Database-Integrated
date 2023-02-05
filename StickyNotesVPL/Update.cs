using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotesVPL
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        public int getNoteId;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection conDB = new MySqlConnection(conSTR);

            if(string.IsNullOrEmpty(note_Type.Text) || string.IsNullOrEmpty(note_Title.Text) || string.IsNullOrEmpty(noteS.Text))
            {
                MessageBox.Show("Fill all fields to Update a Note");
            }
            else
            {
                conDB.Open();

                string updQuery = "UPDATE notes set Note_Type=@noteType, Note_Title=@noteTitle, Notes=@noteText where Note_ID = '"+getNoteId+"'";
                MySqlCommand cmd = new MySqlCommand(updQuery,conDB);
                cmd.Parameters.AddWithValue("@noteType", note_Type.Text.ToString());
                cmd.Parameters.AddWithValue("@noteTitle", note_Title.Text.ToString());
                cmd.Parameters.AddWithValue("@noteText", noteS.Text.ToString());
                cmd.Parameters.AddWithValue("@Note_ID", getNoteId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Note UPDATED successfully :) ");
                conDB.Close();
                clearFields();
                
            }
        }

        public void clearFields()
        {
            note_Type.Text = string.Empty;
            note_Title.Text = string.Empty;
            noteS.Text = string.Empty;
        }

        public void displayNotes()
        {
            ViewNotes vN = new ViewNotes();
            vN.viewNotes();
        }
    }
}
