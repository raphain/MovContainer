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
    public class ContainerStatusController : Controller
    {
        private readonly Context _context;

        public ContainerStatusController(Context context)
        {
            _context = context;
        }

        // GET: ContainerStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContainerStatuses.ToListAsync());
        }

        // GET: ContainerStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerStatus = await _context.ContainerStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (containerStatus == null)
            {
                return NotFound();
            }

            return View(containerStatus);
        }

        // GET: ContainerStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContainerStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] ContainerStatus containerStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(containerStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(containerStatus);
        }

        // GET: ContainerStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerStatus = await _context.ContainerStatuses.FindAsync(id);
            if (containerStatus == null)
            {
                return NotFound();
            }
            return View(containerStatus);
        }

        // POST: ContainerStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] ContainerStatus containerStatus)
        {
            if (id != containerStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(containerStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContainerStatusExists(containerStatus.Id))
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
            return View(containerStatus);
        }

        // GET: ContainerStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containerStatus = await _context.ContainerStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (containerStatus == null)
            {
                return NotFound();
            }

            return View(containerStatus);
        }

        // POST: ContainerStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var containerStatus = await _context.ContainerStatuses.FindAsync(id);
            _context.ContainerStatuses.Remove(containerStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContainerStatusExists(int id)
        {
            return _context.ContainerStatuses.Any(e => e.Id == id);
        }
    }
}
