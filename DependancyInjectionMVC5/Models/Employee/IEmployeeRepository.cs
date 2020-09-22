using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependancyInjectionMVC5.Models
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployee(int id);
        EmployeeModel AddEmployee(EmployeeModel employeeModel);
    }
}