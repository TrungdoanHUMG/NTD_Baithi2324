using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NTD_Baithi2324.Models;

namespace NTD_Baithi2324.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
              return _context.NTD195Student != null ? 
                          View(await _context.NTD195Student.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTD195Student'  is null.");
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTD195Student == null)
            {
                return NotFound();
            }

            var nTD195Student = await _context.NTD195Student
                .FirstOrDefaultAsync(m => m.NTD195StudentID == id);
            if (nTD195Student == null)
            {
                return NotFound();
            }

            return View(nTD195Student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTD195StudentID,NTD195FullName,NTD195MaLOP")] NTD195Student nTD195Student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTD195Student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTD195Student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTD195Student == null)
            {
                return NotFound();
            }

            var nTD195Student = await _context.NTD195Student.FindAsync(id);
            if (nTD195Student == null)
            {
                return NotFound();
            }
            return View(nTD195Student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTD195StudentID,NTD195FullName,NTD195MaLOP")] NTD195Student nTD195Student)
        {
            if (id != nTD195Student.NTD195StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTD195Student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTD195StudentExists(nTD195Student.NTD195StudentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nTD195Student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTD195Student == null)
            {
                return NotFound();
            }

            var nTD195Student = await _context.NTD195Student
                .FirstOrDefaultAsync(m => m.NTD195StudentID == id);
            if (nTD195Student == null)
            {
                return NotFound();
            }

            return View(nTD195Student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTD195Student == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTD195Student'  is null.");
            }
            var nTD195Student = await _context.NTD195Student.FindAsync(id);
            if (nTD195Student != null)
            {
                _context.NTD195Student.Remove(nTD195Student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTD195StudentExists(string id)
        {
          return (_context.NTD195Student?.Any(e => e.NTD195StudentID == id)).GetValueOrDefault();
        }
    }
}
