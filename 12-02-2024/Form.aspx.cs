using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.EnterpriseServices.CompensatingResourceManager;

namespace webApplication4
{
    public partial class Form : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString);
                con.Open();
               
                SqlCommand cmd = new SqlCommand("INSERT INTO Students(StudentName,Age,Course) Values(@StudentName,@Age,@Course)", con);
                     
                    cmd.Parameters.AddWithValue("@StudentName", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Course", TextBox3.Text.Trim());

                    int rows = (int)cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        Response.Write("<script>alert('Registration successful');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Something went wrong!');</script>");
                    }
                    con.Close();
                }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            LoadRecord();
      

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();
            
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadRecord();

        }

        void LoadRecord()

        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString);
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Students",con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            comm.ExecuteNonQuery();
            d.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {

                }
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string StudentName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            int Age = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            string Course = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;


            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Students SET StudentName = @StudentName, Age = @Age, Course = @Course WHERE StudentId = @StudentId", con);
                    cmd.Parameters.AddWithValue("@StudentName", StudentName);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Course", Course);
                    cmd.Parameters.AddWithValue("@StudentId", StudentId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Update successful');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Update failed');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            GridView1.EditIndex = -1;
            LoadRecord();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            try {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentId = @StudentId", con);
                    cmd.Parameters.AddWithValue("@StudentId", StudentId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('delete successful');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('delete failed');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

            GridView1.EditIndex = -1;
            LoadRecord();
        }
            }


}


