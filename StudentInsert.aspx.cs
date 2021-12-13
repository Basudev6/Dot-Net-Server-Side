using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// for saving and retrieving from database
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class StudentInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // database connection
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7;database=IndreniBCADB;integrated security=true");
            conn.Open();

            // sql code to insert
            SqlCommand cmd = new SqlCommand("insert into tbStudent(StudentName, Address, Phone, Email, Course, Gender, DOB) values(@StudentName,@Address,@Phone,@Email,@Course,@Gender,@DOB)");
            cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);


            // link database and code
            cmd.Connection = conn;

            // run the sql code in server
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                Response.Write("Record Submitted Successfully");
            else
                Response.Write("Record Submission Failed");
        }
    }
}