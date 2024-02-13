using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoftware
{
    public partial class Receipt : Form
    {
        public Receipt(string receiptText, decimal price, decimal Gst, decimal Total)
        {
            InitializeComponent();

            groupBox1.Text = receiptText;
            label1.Text = $"price:{price:C}";
            label2.Text = $"Gst: {Gst:C}";
            label3.Text = $"Total: {Total:C}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllItemsFromTable();
            this.Close();
        }
        private void DeleteAllItemsFromTable()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM Product_final";

                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thank you for shopping");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
    }

