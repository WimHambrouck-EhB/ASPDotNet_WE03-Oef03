using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Werkcollege03.Oef03.Data;
using Werkcollege03.Oef03.Models;

namespace Werkcollege03.Oef03.Controllers
{
    public class PuntenController : Controller
    {
        private readonly Werkcollege03Oef03Context _context;

        public PuntenController(Werkcollege03Oef03Context context)
        {
            _context = context;
        }

        // GET: Punten
        public async Task<IActionResult> Index()
        {
            return View(await _context.Punten.ToListAsync());
        }

        // GET: Punten/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var punt = await _context.Punten
                .FirstOrDefaultAsync(m => m.ID == id);
            if (punt == null)
            {
                return NotFound();
            }

            return View(punt);
        }

        // GET: Punten/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Punten/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Score")] Punt punt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(punt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(punt);
        }

        // GET: Punten/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var punt = await _context.Punten.FindAsync(id);
            if (punt == null)
            {
                return NotFound();
            }
            return View(punt);
        }

        // POST: Punten/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Score")] Punt punt)
        {
            if (id != punt.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(punt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuntExists(punt.ID))
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
            return View(punt);
        }

        // GET: Punten/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var punt = await _context.Punten
                .FirstOrDefaultAsync(m => m.ID == id);
            if (punt == null)
            {
                return NotFound();
            }

            return View(punt);
        }

        // POST: Punten/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var punt = await _context.Punten.FindAsync(id);
            _context.Punten.Remove(punt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuntExists(int id)
        {
            return _context.Punten.Any(e => e.ID == id);
        }
    }
}
