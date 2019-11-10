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
    public partial class DeleteStudentUI : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            //DeleteStudentUI deleteStudent=new DeleteStudentUI();
            StudentManager aStudentManager=new StudentManager();
            Student student=new Student();
            student.RegNo = DeleteRegNoTextBoxID.Text;
            aStudentManager.DeleteStudent(student);
            DeleteMsgID.Text = "Deleted!";
            //RegNoDeleteLabel.Text = "e";

        }
    }
}