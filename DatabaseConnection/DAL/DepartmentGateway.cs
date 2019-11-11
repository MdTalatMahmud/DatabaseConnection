using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DatabaseConnection.Model;

namespace DatabaseConnection.DAL
{
    public class DepartmentGateway
    {
        //string connectingStudentTable = WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;
        string connectingStudentTable = WebConfigurationManager.ConnectionStrings["UniversityDBConnectionString"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            SqlConnection aConnection=new SqlConnection(connectingStudentTable);

            string departmentQuery = "SELECT * FROM Departments";
            SqlCommand command=new SqlCommand(departmentQuery,aConnection);

            aConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Department> departmentList=new List<Department>();

            while (reader.Read())
            {
                Department department=new Department();
                department.DepartmentID = (int)reader["DepartmentID"];
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();

                departmentList.Add(department);
            }
            reader.Close();
            aConnection.Close();

            return departmentList;
        }
    }
}