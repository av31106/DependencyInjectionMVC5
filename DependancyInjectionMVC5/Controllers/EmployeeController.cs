using DependancyInjectionMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependancyInjectionMVC5.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _EmployeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        public ActionResult Index()
        {
            var aa = _EmployeeRepository;
            return View();
        }
    }
}