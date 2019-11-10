using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseConnection.BLL;
using DatabaseConnection.Model;

namespace DatabaseConnection.UI
{
    public partial class StudentUpdateUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            StudentManager aStudentManager=new StudentManager();
            Student student=new Student();
            
            student.Name = NameTextBox1.Text;
            student.Email = EmailTextBox2.Text;
            student.Phone = PhnTextBox3.Text;
            student.RegNo = RegNoTextBox4.Text;

            MessageLabel.Text = aStudentManager.UpdateStudent(student);
        }
    }
}