using AutoMapper;
using AutoMapperTest.Models;
using AutoMapperTestData.assembly;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly EmployeeDbContext _context;
        

        public HomeController(ILogger<HomeController> logger, IMapper mapper, EmployeeDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;

        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeModel employeemodel)
        {
            Employee employee = null;
            employee = _mapper.Map<Employee>(employeemodel);
            ////employee.EmployeeId = employeemodel.EmployeeId;
            //employee.FirstName = employeemodel.FirstName;
            //employee.LastName = employeemodel.LastName;
            //employee.Email = employeemodel.Email;
            //employee.DateOfBrith = employeemodel.DateOfBrith;
           
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("AddEmployee");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
