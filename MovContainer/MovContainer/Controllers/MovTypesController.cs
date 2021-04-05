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
    public class MovTypesController : Controller
    {
        private readonly Context _context;

        public MovTypesController(Context context)
        {
            _context = context;
        }

        // GET: MovTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MovTypes.ToListAsync());
        }

        // GET: MovTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movType = await _context.MovTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movType == null)
            {
                return NotFound();
            }

            return View(movType);
        }

        // GET: MovTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] MovType movType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movType);
        }

        // GET: MovTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movType = await _context.MovTypes.FindAsync(id);
            if (movType == null)
            {
                return NotFound();
            }
            return View(movType);
        }

        // POST: MovTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] MovType movType)
        {
            if (id != movType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovTypeExists(movType.Id))
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
            return View(movType);
        }

        // GET: MovTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movType = await _context.MovTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movType == null)
            {
                return NotFound();
            }

            return View(movType);
        }

        // POST: MovTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movType = await _context.MovTypes.FindAsync(id);
            _context.MovTypes.Remove(movType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovTypeExists(int id)
        {
            return _context.MovTypes.Any(e => e.Id == id);
        }
    }
}
