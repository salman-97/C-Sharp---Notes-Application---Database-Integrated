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
    public partial class ViewNotes : Form
    {
        public ViewNotes()
        {
            InitializeComponent();
            viewNotes();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void viewNotes()
        {
            DataTable notesTable = new DataTable();

            notesTable.Clear();

            string conSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection viewTable = new MySqlConnection(conSTR);

            viewTable.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from notes",viewTable);
            MySqlDataReader readNotes = cmd.ExecuteReader();

            notesTable.Load(readNotes);
            notesDGV.DataSource = notesTable;

            readNotes.Close();
            viewTable.Close();
        }

        private void notesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int noteID = Convert.ToInt32(notesDGV.Rows[notesDGV.CurrentRow.Index].Cells[0].Value);

            // for this to work: next form to redirect, the TEXTFIELDS MODIFIERS should be set to PUBLIC //

            Update upd = new Update();

            upd.note_Type.Text = this.notesDGV.CurrentRow.Cells[1].Value.ToString();
            upd.note_Title.Text = this.notesDGV.CurrentRow.Cells[2].Value.ToString();
            upd.noteS.Text = this.notesDGV.CurrentRow.Cells[3].Value.ToString();
            upd.getNoteId = noteID;
            upd.ShowDialog();
            viewNotes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int noteid = Convert.ToInt32(notesDGV.Rows[notesDGV.CurrentRow.Index].Cells[0].Value);

            string dbSTR = "server=127.0.0.1; port=3306; username=root; password=; database=salmanstickynotesapplication";
            MySqlConnection connectDB = new MySqlConnection(dbSTR);

            if (MessageBox.Show("Are you sure you want to delete the Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connectDB.Open();

                MySqlCommand cmd = new MySqlCommand("Delete from notes where Note_ID = '" + noteid + "'", connectDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");

                connectDB.Close();
            }
            else
            {
                MessageBox.Show("No record deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            viewNotes();
        }
    }
}
