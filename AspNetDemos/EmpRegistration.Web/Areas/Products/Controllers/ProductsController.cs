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
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductCategoriesController> _logger;

        public ProductsController(
            ApplicationDbContext context,
            ILogger<ProductCategoriesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Products/Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Products/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategory, "ProductCategoryId", "ProductCategoryName");
            return View();
        }

        // POST: Products/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Discontinued,ProductCategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.ProductName = product.ProductName.Trim();

                bool isDuplicateFound
                    = _context.Products.Any(p => p.ProductName == product.ProductName);
                if (isDuplicateFound)
                {
                    ModelState.AddModelError("ProductName", "Duplicate! Another product with the same name exists");
                }
                else
                { 
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategory, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
            return View(product);
        }

        // GET: Products/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategory, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
            return View(product);
        }

        // POST: Products/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Discontinued,ProductCategoryId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                product.ProductName = product.ProductName.Trim();
                bool isDuplicateFound
                    = _context.Products.Any(p => p.ProductName == product.ProductName
                                                            && p.ProductId == product.ProductId);
                if (isDuplicateFound)
                {
                    ModelState.AddModelError("ProductName", "A Duplicate category was found!");
                }
                else
                {
                    try
                    {
                        _context.Update(product);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductExists(product.ProductId))
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
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategory, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
            return View(product);
        }

        // GET: Products/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
