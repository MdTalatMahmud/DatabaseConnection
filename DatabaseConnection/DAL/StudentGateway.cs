using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DatabaseConnection.Model;

namespace DatabaseConnection.DAL
{
    public class StudentGateway
    {
        string connectingStudentTable = WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;//create connection
        public int SaveStudent(Student aStudent)
        {
            //string connectingStudentTable = WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;//create connection

            SqlConnection aConnection = new SqlConnection(connectingStudentTable);//creating object of SqlConnection

            string query = "INSERT INTO Student VALUES('" + aStudent.Name + "', '" + aStudent.Email + "', '" + aStudent.Phone + "', '" + aStudent.RegNo + "')";

            SqlCommand aSqlCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            //aSqlCommand.ExecuteNonQuery();

            int affectedRowNumber = aSqlCommand.ExecuteNonQuery();

            aConnection.Close();

            return affectedRowNumber;
        }

        public List<Student> GetAllStudents()
        {
            string connectingStudentTable =
                @"Server=TALATMAHMUD-PC;Database=UniversityDatabase;Integrated Security=true";//create connection
            SqlConnection aConnection = new SqlConnection(connectingStudentTable);
            string query = "SELECT * FROM Student;";
            SqlCommand aSqlCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Student> studentsList = new List<Student>();
            while (aSqlDataReader.Read())
            {
                Student student = new Student();

                student.Name = aSqlDataReader["Name"/*Sql entity value*/].ToString();
                student.Email = aSqlDataReader["Email"/*Sql entity value*/].ToString();
                student.Phone = aSqlDataReader["PhnNo"/*Sql entity value*/].ToString();
                student.RegNo = aSqlDataReader["RegNo"/*Sql entity value*/].ToString();


                studentsList.Add(student);
            }
            aSqlDataReader.Close();
            aConnection.Close();

            return studentsList;
        }

        public bool UpdateStudent(Student aStudent)
        {
            SqlConnection aSqlConnection = new SqlConnection(connectingStudentTable);
            string query = "UPDATE Student SET Name='"+aStudent.Name+"', Email='"+aStudent.Email+"',PhnNo='"+aStudent.Phone+"' WHERE RegNo='"+aStudent.RegNo+"' ";
            SqlCommand command=new SqlCommand(query,aSqlConnection);
            aSqlConnection.Open();
            int rowAffected=command.ExecuteNonQuery();
            aSqlConnection.Close();

            if (rowAffected>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteStudent(Student aStudent)
        {
            SqlConnection aSqlConnection=new SqlConnection(connectingStudentTable);
            string query = "DELETE FROM Student WHERE RegNo='"+aStudent.RegNo+"' ";
            SqlCommand command = new SqlCommand(query,aSqlConnection);
            aSqlConnection.Open();
            int rowAffect = command.ExecuteNonQuery();
            aSqlConnection.Close();

            if (rowAffect>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
}