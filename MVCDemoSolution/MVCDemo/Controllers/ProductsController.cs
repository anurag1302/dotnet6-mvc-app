using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Country"] = "India";
            ViewData["PrimeNumber"] = 3;

            var model = new EmployeeViewModel
            {
                Id = 23,
                Name = "John"
            };

            ViewData["EmpModel"] = model.Name;

            ViewBag.FirstName = "John";
            ViewBag.LastName = "Doe";
            ViewBag.CreatedDate = DateTime.Now;
            ViewBag.IsAContractualEmployee = true;

            return View();
        }

        public IActionResult ProductDetails()
        {
            var model = ProductRepository.GetProducts();
            return View(model);
        }

        public IActionResult ProductReport()
        {
            var products = ProductRepository.GetProducts();
            var model = new BaseProductViewModel
            {
                Products = products,
                Count = products.Count(),
                LatestOrderDate = products.Max(x => x.OrderedDate).Value
            };
            return View(model);
        }
    }
}