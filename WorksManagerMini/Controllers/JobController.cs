using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorksManagerMini.Data;
using WorksManagerMini.Models;

namespace WorksManagerMini.Controllers
{
    public class JobsController : Controller
    {
        private readonly AppDbContext _context;
        public JobsController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Index() => View(await _context.Jobs.ToListAsync());
        public async Task<IActionResult> Dashboard() => View(await _context.Jobs.ToListAsync());

        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(Job job)
        {
            job.CreatedDate = DateTime.Now;
            _context.Add(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id) => View(await _context.Jobs.FindAsync(id));
        [HttpPost]
        public async Task<IActionResult> Edit(Job job)
        {
            _context.Update(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id) => View(await _context.Jobs.FindAsync(id));
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}