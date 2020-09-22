using DependancyInjectionMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependancyInjectionMVC5.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _EmployeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        // GET: Home
        public ActionResult Index()
        {
            _EmployeeRepository.AddEmployee(new EmployeeModel() { Id = 1, Name = "ANIL", Code = "NXT00112" });
            _EmployeeRepository.AddEmployee(new EmployeeModel() { Id = 2, Name = "ANIL KUMAR", Code = "NXT00113" });
            var aa = _EmployeeRepository;
            return View();
        }
    }
}