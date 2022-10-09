using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_App
{
    public partial class AddForm : Form
    {
        public int NoteId { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (NoteId == 0)
            {
                string query = "Insert Into Notes (Subject,Text,CreateDate) Values (@Subject,@Text,@CreateDate)";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@Subject", txt_subject.Text);
                command.Parameters.AddWithValue("@Text", txt_txt.Text);
                command.Parameters.AddWithValue("@CreateDate", DateTime.Now);

                Program.connection.Open();
                command.ExecuteNonQuery();
                Program.connection.Close();
                MessageBox.Show("یادداشت با موفقیت ثبت شد.");
                
            }
            else
            {
                string query = "Update Notes Set Subject=@Subject,Text=@Text,EditDate=@EditDate where NoteID=@NoteID";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@NoteID", NoteId);
                command.Parameters.AddWithValue("@Subject", txt_subject.Text);
                command.Parameters.AddWithValue("@Text", txt_txt.Text);
                command.Parameters.AddWithValue("@EditDate", DateTime.Now);

                Program.connection.Open();
                command.ExecuteNonQuery();
                Program.connection.Close();
                MessageBox.Show("یادداشت با موفقیت ویرایش شد.");
            }
            DialogResult = DialogResult.OK;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (NoteId != 0)
            {
                string query = "select Subject,Text from Notes where NoteID=@NoteId";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@NoteID", NoteId);
                Program.connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txt_subject.Text = dr["Subject"].ToString();
                    txt_txt.Text = dr["Text"].ToString();
                }
                Program.connection.Close();

            }
        }
    }
}
