using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseConnection.DAL;
using DatabaseConnection.Model;

namespace DatabaseConnection.BLL
{
    public class StudentManager
    {
        StudentGateway aStudentGateway=new StudentGateway();


        public string SaveStudent(Student aStudent)
        {
            if (aStudent.RegNo.Length >= 3)
            {
                int affectedRowNumber = aStudentGateway.SaveStudent(aStudent);
                if (affectedRowNumber > 0)
                {
                    //show message
                    return "Saved Successfully!";
                }
                else
                {
                    //show message
                    return "Failed! Please try again later";
                }
            }
            else
            {
                return "Reg No must be at least 3 digits";
            }
            
        }

        public List<Student> GetAllStudents()
        {
            return aStudentGateway.GetAllStudents();
        }

        public string UpdateStudent(Student student)
        {
            if (aStudentGateway.UpdateStudent(student)==true)
            {
                return "update successful!";
            }
            else
            {
                return "Sorry, not successful. Try again";
            }
            
            
        }
    }
}