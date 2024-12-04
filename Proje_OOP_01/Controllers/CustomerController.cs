using Microsoft.AspNetCore.Mvc;
using Proje_OOP_01.Entity;
using Proje_OOP_01.ProjeContext;

namespace Proje_OOP_01.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if (p.Name.Length>=6 && p.City!="" && p.City.Length>=3 && p.Name != "")
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı Giriş";
                return View();
            }
            
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.ID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(y => y.ID == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.Customers.Where(y => y.ID == p.ID).FirstOrDefault();
            value.Name = p.Name;
            value.City = p.City;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
