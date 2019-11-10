using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseConnection.BLL;
using DatabaseConnection.Model;

namespace DatabaseConnection
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //name 
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //email
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //phn no
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            //reg no
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            StudentManager aStudentManager = new StudentManager();

            string name = TextBox1.Text;//data transfer object(DTO) creating >>> Student aStudent= new Student(name,email,phnNo,regNo);
            string email = TextBox2.Text;
            string phnNo = TextBox3.Text;
            string regNo = TextBox4.Text;

            Student aStudent= new Student(name,email,phnNo,regNo);
            

            MessageLabel.Text= aStudentManager.SaveStudent(aStudent);
            //MessageLabel.Text=
            //This is a test comment
                
            
            
        }
    }
}