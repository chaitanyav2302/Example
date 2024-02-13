using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Edit : Form
    {
        public int ItemId { get; private set; }
        public string ItemName { get; private set; }
        public int Quantity { get; private set; }
        public int  Price { get; private set; }
       
        public Edit(int itemid, string itemName, int itemQuantity, int itemCost)
        {
            InitializeComponent();
            textBox3.Text = Convert.ToString(itemid);
            textBox3.ReadOnly = true;
            textBox1.Text = itemName;
            textBox2.Text = Convert.ToString(itemCost);
            numericUpDown1.Value = itemQuantity;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void GetEditedItemDetails(out string itemName, out int itemCost, out int itemQuantity)
        {
            itemName = textBox1.Text;
            itemCost= Convert.ToInt32(textBox3.Text);
            itemQuantity = (int)numericUpDown1.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ItemId = Convert.ToInt32(textBox3.Text);
            ItemName = textBox1.Text;
            Quantity = (int)numericUpDown1.Value;
            Price = Convert.ToInt32(textBox2.Text);
           

          
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;

            
            this.Close();
        }
    }
}

