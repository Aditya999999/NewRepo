using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpRegistration.Web.Data;
using EmpRegistration.Web.Models;

namespace EmpRegistration.Web.Areas.Employees.Controllers
{
    [Area("Employees")]
    public class EmployeeRegistrationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRegistrationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees/EmployeeRegistrations
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeRegistration.ToListAsync());
        }

        // GET: Employees/EmployeeRegistrations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration
                .FirstOrDefaultAsync(m => m.Phone == id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }

            return View(employeeRegistration);
        }

        // GET: Employees/EmployeeRegistrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/EmployeeRegistrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Password,Address,Country,Gender,Phone")] EmployeeRegistration employeeRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeRegistration);
        }

        // GET: Employees/EmployeeRegistrations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration.FindAsync(id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }
            return View(employeeRegistration);
        }

        // POST: Employees/EmployeeRegistrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,Email,Password,Address,Country,Gender,Phone")] EmployeeRegistration employeeRegistration)
        {
            if (id != employeeRegistration.Phone)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeRegistration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeRegistrationExists(employeeRegistration.Phone))
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
            return View(employeeRegistration);
        }

        // GET: Employees/EmployeeRegistrations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration
                .FirstOrDefaultAsync(m => m.Phone == id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }

            return View(employeeRegistration);
        }

        // POST: Employees/EmployeeRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employeeRegistration = await _context.EmployeeRegistration.FindAsync(id);
            _context.EmployeeRegistration.Remove(employeeRegistration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeRegistrationExists(string id)
        {
            return _context.EmployeeRegistration.Any(e => e.Phone == id);
        }
    }
}
