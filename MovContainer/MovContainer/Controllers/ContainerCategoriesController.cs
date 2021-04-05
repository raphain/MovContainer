using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovContainer.Models;

namespace MovContainer.Controllers
{
    public class ContainerCategoriesController : Controller
    {
        private readonly Context _context;

        public ContainerCategoriesController(Context context)
        {
            _context = context;
        }

        // GET: ContainerCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContainerCategories.ToListAsync());
        }

        // GET: ContainerCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerCategory = await _context.ContainerCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (containerCategory == null)
            {
                return NotFound();
            }

            return View(containerCategory);
        }

        // GET: ContainerCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContainerCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] ContainerCategory containerCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(containerCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(containerCategory);
        }

        // GET: ContainerCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerCategory = await _context.ContainerCategories.FindAsync(id);
            if (containerCategory == null)
            {
                return NotFound();
            }
            return View(containerCategory);
        }

        // POST: ContainerCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] ContainerCategory containerCategory)
        {
            if (id != containerCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(containerCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContainerCategoryExists(containerCategory.Id))
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
            return View(containerCategory);
        }

        // GET: ContainerCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerCategory = await _context.ContainerCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (containerCategory == null)
            {
                return NotFound();
            }

            return View(containerCategory);
        }

        // POST: ContainerCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var containerCategory = await _context.ContainerCategories.FindAsync(id);
            _context.ContainerCategories.Remove(containerCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContainerCategoryExists(int id)
        {
            return _context.ContainerCategories.Any(e => e.Id == id);
        }
    }
}
