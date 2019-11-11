using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseConnection.DAL;
using DatabaseConnection.Model;

namespace DatabaseConnection.BLL
{
    public class DepartmentManagement
    {
        DepartmentGateway aDepartmentGateway=new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return
                aDepartmentGateway.GetAllDepartments();
        }
    }
}