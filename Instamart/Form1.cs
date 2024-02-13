using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Instamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=EPINHYDW0BE6\\SQLEXPRESS;Initial Catalog=InstaMart;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values(@Name,@Email,@Gender,@Password)",conn);
            
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email",textBox3.Text );
            cmd.Parameters.AddWithValue("@Gender", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox4.Text);
            int rows=cmd.ExecuteNonQuery();
            conn.Close();
            
            
            if (rows > 0)
            {
                MessageBox.Show("successfully inserted");
            }
            else
            {
                MessageBox.Show("not inserted");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZZ
        }
    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
