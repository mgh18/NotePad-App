using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace NotePad_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("dddd dd MMMM yyyy - HH:mm:ss");
            grdList.DataSource = LoadList();
        }
        public DataTable LoadList()
        {
            string query = "select NoteID,Subject,CreateDate,EditDate from Notes";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("dddd dd MMMM yyyy - HH:mm:ss");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AddForm adf = new AddForm();
            adf.NoteId = 0;
            
            if(adf.ShowDialog() == DialogResult.OK)
            {
                grdList.DataSource = LoadList();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int noteId = (int)grdList.SelectedRows[0].Cells["NoteID"].Value;
            string subject = (string)grdList.SelectedRows[0].Cells["Subject"].Value;
            AddForm adf = new AddForm();
            adf.btn_save.Text = "ویرایش";
            adf.txt_newtxt.Text = " ویرایش یادداشت " + subject;
            adf.NoteId = noteId;
            if (adf.ShowDialog() == DialogResult.OK)
            {
                grdList.DataSource = LoadList();
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int noteId = (int)grdList.SelectedRows[0].Cells["NoteID"].Value;
            string subject = (string)grdList.SelectedRows[0].Cells["Subject"].Value;
            DialogResult mes = MessageBox.Show("آیا میخواهید این یادداشت را حذف کنید؟", subject, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mes== DialogResult.Yes)
            {
                string query = "Delete from Notes where NoteID=@NoteID";
                SqlCommand command = new SqlCommand(query, Program.connection);
                command.Parameters.AddWithValue("@NoteID", noteId);
                Program.connection.Open();
                command.ExecuteNonQuery();
                Program.connection.Close();
                grdList.DataSource = LoadList();

            }


        }
    }
}
