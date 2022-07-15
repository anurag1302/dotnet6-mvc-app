using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult EmployeeDetails()
        {
            var employees = new List<EmployeeViewModel>
            {
                new EmployeeViewModel
                {
                    Id=101,
                    Name="Arshad",
                    City="Hyd",
                    CreatedDate=DateTime.Now,
                    YearsOfExperience=6
                },
                new EmployeeViewModel
                {
                    Id=102,
                    Name="Abhishek",
                    City="Hyd",
                    CreatedDate=DateTime.Now.AddMinutes(10),
                    YearsOfExperience=4
                },
                new EmployeeViewModel
                {
                    Id=103,
                    Name="Sanjay",
                    City="Hyd",
                    CreatedDate=DateTime.Now.AddMinutes(20),
                    YearsOfExperience=8
                },
            };

            return View(employees);
        }
    }
}