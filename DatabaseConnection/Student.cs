using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseConnection
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RegNo { get; set; }

        public Student(string name, string email, string phone, string regNo)
        {
            Name = name;
            Email = email;
            Phone = phone;
            RegNo = regNo;
        }

        public Student()
        {
            //default constructor
        }
    }
}