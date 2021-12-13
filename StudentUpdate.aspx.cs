using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class StudentUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // database connection
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7;database=IndreniBCADB;integrated security=true") ;
            conn.Open();

            // sql code to update
            SqlCommand cmd = new SqlCommand("update tbStudent set StudentName=@StudentName, Address=@Address, Phone=@Phone, Email=@Email, Course=@Course, Gender=@Gender, DOB=@DOB where StudentID=@StudentID");
            cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);



            // link database and code
            cmd.Connection = conn;

            // run the sql code in server
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                Response.Write("Record Updated Successfully");
            else
                Response.Write("Record Updation Failed");


        }
    }
}