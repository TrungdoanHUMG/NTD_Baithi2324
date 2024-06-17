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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
              return _context.NTD195Employee != null ? 
                          View(await _context.NTD195Employee.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTD195Employee'  is null.");
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTD195Employee == null)
            {
                return NotFound();
            }

            var nTD195Employee = await _context.NTD195Employee
                .FirstOrDefaultAsync(m => m.NTD195EmployeeID == id);
            if (nTD195Employee == null)
            {
                return NotFound();
            }

            return View(nTD195Employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTD195EmployeeID,NTD195FullName,NTD195Address")] NTD195Employee nTD195Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTD195Employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTD195Employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTD195Employee == null)
            {
                return NotFound();
            }

            var nTD195Employee = await _context.NTD195Employee.FindAsync(id);
            if (nTD195Employee == null)
            {
                return NotFound();
            }
            return View(nTD195Employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTD195EmployeeID,NTD195FullName,NTD195Address")] NTD195Employee nTD195Employee)
        {
            if (id != nTD195Employee.NTD195EmployeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTD195Employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTD195EmployeeExists(nTD195Employee.NTD195EmployeeID))
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
            return View(nTD195Employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTD195Employee == null)
            {
                return NotFound();
            }

            var nTD195Employee = await _context.NTD195Employee
                .FirstOrDefaultAsync(m => m.NTD195EmployeeID == id);
            if (nTD195Employee == null)
            {
                return NotFound();
            }

            return View(nTD195Employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTD195Employee == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTD195Employee'  is null.");
            }
            var nTD195Employee = await _context.NTD195Employee.FindAsync(id);
            if (nTD195Employee != null)
            {
                _context.NTD195Employee.Remove(nTD195Employee);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTD195EmployeeExists(string id)
        {
          return (_context.NTD195Employee?.Any(e => e.NTD195EmployeeID == id)).GetValueOrDefault();
        }
    }
}
