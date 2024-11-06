using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement
{
    public partial class Enrollment : Form
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=schooldb;Integrated Security=True;";

        public Enrollment()
        {
            InitializeComponent();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            LoadStudentNames();
            LoadSubjects();
        }

        private void LoadStudentNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentName FROM studentab", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["StudentName"].ToString());
                }
            }
        }

        private void LoadSubjects()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SubjectName FROM subtab", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["SubjectName"].ToString());
                }
            }
        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=localhost;Initial Catalog=schooldb;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO enrolltable (enid, studentname, subject, enrolldate) VALUES (@EnId, @StudentName, @Subject, @EnrollDate)", con);
            cmd.Parameters.AddWithValue("@EnId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StudentName", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Subject", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=localhost;Initial Catalog=schooldb;Integrated Security=True;");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from enrolltable", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=localhost;Initial Catalog=schooldb;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE enrolltable SET studentname=@StudentName, subject=@Subject, enrolldate=@EnrollDate WHERE enid=@EnId", con);
            cmd.Parameters.AddWithValue("@EnId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StudentName", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Subject", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=localhost;Initial Catalog=schooldb;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM enrolltable WHERE enid=@EnId", con);
            cmd.Parameters.AddWithValue("@EnId", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
