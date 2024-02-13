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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BillingSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BillingSoftware
{
    public partial class Form1 : Form
    {



      public void  UpdateItemInDatabase(int itemId, string editedItemName, int editedItemCost, int editedItemQuantity)
        {
            
                using (SqlConnection conn = new SqlConnection("Data Source=EPINHYDW0BE6\\SQLEXPRESS;Initial Catalog=InstaMart;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Product_final SET ItemName = @editedItemName, Quantity = @editedItemQuantity, Price = @editedItemCost WHERE ItemId = @itemId", conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@editedItemName", editedItemName);
                        cmd.Parameters.AddWithValue("@editedItemQuantity", editedItemQuantity);
                        cmd.Parameters.AddWithValue("@editedItemCost", editedItemCost);
                        cmd.Parameters.AddWithValue("@itemId", itemId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Update successful");
                        }
                        else
                        {
                            MessageBox.Show("Update failed");
                        }
                    }
                }
            }

            void showTable()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product_final";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }


            conn.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=EPINHYDW0BE6\\SQLEXPRESS;Initial Catalog=InstaMart;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Product_final(ItemName,Quantity,Price)values(@ItemName,@Quantity,@Price)", conn);

            cmd.Parameters.AddWithValue("@ItemName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));

            int rows = cmd.ExecuteNonQuery();
           


            if (rows > 0)
            {
                MessageBox.Show("successfully inserted");

            }
            else
            {
                MessageBox.Show("not inserted");
            }
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemId"].Value);
                string itemName = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ItemName"].Value);
                int itemQuantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                int itemCost = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Price"].Value);

               
                Edit editForm = new Edit(itemId, itemName, itemQuantity, itemCost);
                DialogResult result = editForm.ShowDialog();

               
                if (result == DialogResult.OK)
                {
                    
                    editForm.GetEditedItemDetails(out string editedItemName, out int editedItemCost, out int editedItemQuantity);

                    
                    UpdateItemInDatabase(itemId, editedItemName, editedItemCost, editedItemQuantity);

                    
                    showTable();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemId"].Value);
                SqlConnection conn = new SqlConnection("Data Source=EPINHYDW0BE6\\SQLEXPRESS;Initial Catalog=InstaMart;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Product_final where ItemId = @ItemId", conn);

                cmd.Parameters.AddWithValue("@ItemId", itemId);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();


                if (rows > 0)
                {
                    MessageBox.Show("successfully deleted");

                }
                else
                {
                    MessageBox.Show("not executed");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           decimal price = 0;
            StringBuilder receiptText = new StringBuilder();
            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string itemName = Convert.ToString(row.Cells["itemname"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    int Price = Convert.ToInt32(row.Cells["price"].Value);


                    decimal itemSubtotal = Quantity * Price;
                    price += itemSubtotal;

                    receiptText.AppendLine($"{itemName} - {Quantity} x {Price:C} = {itemSubtotal:C}");
                }
            }


            int gstPercentage = 5;
            decimal Gst = (price * gstPercentage) / 100;
            decimal Total = price + Gst;

            Receipt receiptForm = new Receipt(receiptText.ToString(), price, Gst, Total);
            receiptForm.ShowDialog();
            showTable();
            this.Focus();
        }


    }
    }


