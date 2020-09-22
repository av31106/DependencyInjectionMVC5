using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependancyInjectionMVC5.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeModel> _EmployeeList;

        public MockEmployeeRepository()
        {
            _EmployeeList = new List<EmployeeModel>();
        }
        public EmployeeModel AddEmployee(EmployeeModel employeeModel)
        {
            _EmployeeList.Add(employeeModel);
            return employeeModel;
        }

        public EmployeeModel GetEmployee(int id)
        {
            return _EmployeeList.Where(col => col.Id == id).FirstOrDefault();
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _EmployeeList;
        }
    }
}