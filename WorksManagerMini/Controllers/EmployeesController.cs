using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorksManagerMini.Data;
using WorksManagerMini.Models;

namespace WorksManagerMini.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeesController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            ViewBag.Total = employees.Count;
            ViewBag.Managers = employees.Count(e => e.Role == "Manager");
            ViewBag.Workers = employees.Count(e => e.Role == "Worker");
            return View(employees);
        }
        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // EDIT DA MACHAN
        public async Task<IActionResult> Edit(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            return View(emp);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // DELETE DA MACHAN
        public async Task<IActionResult> Delete(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            return View(emp);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}