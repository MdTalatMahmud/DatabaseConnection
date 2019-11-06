using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnection
{
    public partial class ShowAllStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectingStudentTable =
                @"Server=TALATMAHMUD-PC;Database=UniversityDatabase;Integrated Security=true";//create connection
            SqlConnection aConnection=new SqlConnection(connectingStudentTable);
            string query= "SELECT * FROM Student;";
            SqlCommand aSqlCommand=new SqlCommand(query,aConnection);
            aConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Student> studentsList=new List<Student>();
            while (aSqlDataReader.Read())
            {
                Student student=new Student();

                student.Name = aSqlDataReader["Name"/*Sql entity value*/].ToString();
                student.Email = aSqlDataReader["Email"/*Sql entity value*/].ToString();
                student.Phone = aSqlDataReader["PhnNo"/*Sql entity value*/].ToString();
                student.RegNo = aSqlDataReader["RegNo"/*Sql entity value*/].ToString();
                

                studentsList.Add(student);
            }
            aSqlDataReader.Close();
            aConnection.Close();
            StudentGridView.DataSource = studentsList;
            StudentGridView.DataBind();
        }
    }
}