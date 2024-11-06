using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher te = new Teacher();
            te.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject sj = new Subject();
            sj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section sc = new Section();
            sc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
