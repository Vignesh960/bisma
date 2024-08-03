using AutoMapper;
using Bishmaji.DataDBContext;
using Bishmaji.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bishmaji.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDBContext appDBContext;

        public EmployeeController(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            // ViewData["departments"]=appDBContext.Department.ToList();
            ViewBag.Departments = appDBContext.Department.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await appDBContext.AddAsync(employee);
                await appDBContext.SaveChangesAsync();
                return RedirectToAction("ListAll", "Employee");
            }

            ViewBag.Departments = appDBContext.Department.ToList();
            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> ListAll()
        {
            return View(await appDBContext.Employee.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await appDBContext.Employee.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (res is not null)
            {
                appDBContext.Remove(res);
                await appDBContext.SaveChangesAsync();
                TempData["Deleted"] = $"{res.EmployeeName} Deleted Succesfully..!";
            }
            return RedirectToAction("ListAll", "Employee");
        }


    }
}
