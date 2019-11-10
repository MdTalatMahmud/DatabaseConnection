using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseConnection.BLL;
using DatabaseConnection.DAL;
using DatabaseConnection.Model;

namespace DatabaseConnection
{
    public partial class ShowAllStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            StudentManager aStudentManager=new StudentManager();            

            StudentGridView.DataSource = aStudentManager.GetAllStudents();
            StudentGridView.DataBind();
        }
    }
}