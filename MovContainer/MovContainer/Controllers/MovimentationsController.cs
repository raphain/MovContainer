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
    public class MovimentationsController : Controller
    {
        private readonly Context _context;

        public MovimentationsController(Context context)
        {
            _context = context;
        }

        // GET: Movimentations1
        public async Task<IActionResult> Index()
        {
            var context = _context.Movimentations.Include(m => m.Container).Include(m => m.MovType);
            return View(await context.ToListAsync());
        }

        // GET: Movimentations1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentation = await _context.Movimentations
                .Include(m => m.Container)
                .Include(m => m.MovType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movimentation == null)
            {
                return NotFound();
            }

            return View(movimentation);
        }

        // GET: Movimentations1/Create
        public IActionResult Create()
        {
            ViewData["ContainerId"] = new SelectList(_context.Containers, "Id", "Number");
            ViewData["MovTypeId"] = new SelectList(_context.MovTypes, "Id", "Description");
            return View();
        }

        // POST: Movimentations1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovTypeId,ContainerId,Dt_Init,Dt_Fin")] Movimentation movimentation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movimentation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContainerId"] = new SelectList(_context.Containers, "Id", "Number", movimentation.ContainerId);
            ViewData["MovTypeId"] = new SelectList(_context.MovTypes, "Id", "Description", movimentation.MovTypeId);
            return View(movimentation);
        }

        // GET: Movimentations1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentation = await _context.Movimentations.FindAsync(id);
            if (movimentation == null)
            {
                return NotFound();
            }
            ViewData["ContainerId"] = new SelectList(_context.Containers, "Id", "Number", movimentation.ContainerId);
            ViewData["MovTypeId"] = new SelectList(_context.MovTypes, "Id", "Description", movimentation.MovTypeId);
            return View(movimentation);
        }

        // POST: Movimentations1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovTypeId,ContainerId,Dt_Init,Dt_Fin")] Movimentation movimentation)
        {
            if (id != movimentation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movimentation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovimentationExists(movimentation.Id))
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
            ViewData["ContainerId"] = new SelectList(_context.Containers, "Id", "Number", movimentation.Container);
            ViewData["MovTypeId"] = new SelectList(_context.MovTypes, "Id", "Description", movimentation.MovTypeId);
            return View(movimentation);
        }

        // GET: Movimentations1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentation = await _context.Movimentations
                .Include(m => m.Container)
                .Include(m => m.MovType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movimentation == null)
            {
                return NotFound();
            }

            return View(movimentation);
        }

        // POST: Movimentations1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movimentation = await _context.Movimentations.FindAsync(id);
            _context.Movimentations.Remove(movimentation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimentationExists(int id)
        {
            return _context.Movimentations.Any(e => e.Id == id);
        }
    }
}
