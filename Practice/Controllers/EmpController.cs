using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.DataContext;
using Practice.Models;

namespace Practice.Controllers
{
    public class EmpController : Controller
    {
        private readonly appDbContext appDbContext;

        public EmpController(appDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmp()
        {
            ViewBag.Departments=appDbContext.Dept.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmp(Emp emp)
        {
            if (ModelState.IsValid)
            {
                await appDbContext.Emp.AddAsync(emp);
                await appDbContext.SaveChangesAsync();
                ViewData["Success"] = $"Succesfully Added {emp.Name} Employee..!";
            }
            ViewBag.Departments = await appDbContext.Dept.ToListAsync();
            return RedirectToAction("AddEmp", "Emp");
        }
    }
}
