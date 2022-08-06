using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpRegistration.Web.Data;
using EmpRegistration.Web.Models;
using Microsoft.Extensions.Logging;

namespace EmpRegistration.Web.Areas.Products.Controllers
{
    [Area("Products")]
    public class ProductCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductCategoriesController> _logger;

        public ProductCategoriesController(
            ApplicationDbContext context,
            ILogger<ProductCategoriesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Products/ProductCategories
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("----Retrieved all the Categories from the database.");
            return View(await _context.ProductCategory.ToListAsync());
        }

        // GET: Products/ProductCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategory
                .FirstOrDefaultAsync(m => m.ProductCategoryId == id);
            if (productCategory == null)
            {
                return NotFound();
            }

            return View(productCategory);
        }

        // GET: Products/ProductCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/ProductCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductCategoryId,ProductCategoryName")] ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                productCategory.ProductCategoryName = productCategory.ProductCategoryName.Trim();
                
                bool isDuplicateFound
                    = _context.ProductCategory.Any(p => p.ProductCategoryName == productCategory.ProductCategoryName);

                if (isDuplicateFound)
                {
                    ModelState.AddModelError("ProductCategoryName", "Duplicate! Another category with the same name exists");
                }
                else
                {

                    _context.Add(productCategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(productCategory);
        }

        // GET: Products/ProductCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategory.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }
            return View(productCategory);
        }

        // POST: Products/ProductCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductCategoryId,ProductCategoryName")] ProductCategory productCategory)
        {
            if (id != productCategory.ProductCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                productCategory.ProductCategoryName = productCategory.ProductCategoryName.Trim();
                bool isDuplicateFound
                    = _context.ProductCategory.Any(p => p.ProductCategoryName == productCategory.ProductCategoryName
                                                            && p.ProductCategoryId == productCategory.ProductCategoryId);
                if (isDuplicateFound)
                {
                    ModelState.AddModelError("CategoryName", "A Duplicate category was found!");
                }
                else
                {
                    try
                    {
                        _context.Update(productCategory);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductCategoryExists(productCategory.ProductCategoryId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                
            }
            return View(productCategory);
        }

        // GET: Products/ProductCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategory
                .FirstOrDefaultAsync(m => m.ProductCategoryId == id);
            if (productCategory == null)
            {
                return NotFound();
            }

            return View(productCategory);
        }

        // POST: Products/ProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productCategory = await _context.ProductCategory.FindAsync(id);
            _context.ProductCategory.Remove(productCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategory.Any(e => e.ProductCategoryId == id);
        }
    }
}
