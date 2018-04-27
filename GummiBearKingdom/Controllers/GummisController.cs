using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Controllers
{
    public class GummisController : Controller
    {
        private readonly GummiBearKingdomDbContext _context;

        public GummisController(GummiBearKingdomDbContext context)
        {
            _context = context;    
        }

        // GET: Gummis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gummis.ToListAsync());
        }

        // GET: Gummis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gummi = await _context.Gummis
                .SingleOrDefaultAsync(m => m.GummiId == id);
            if (gummi == null)
            {
                return NotFound();
            }

            return View(gummi);
        }

        // GET: Gummis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gummis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GummiId,Name,Price,Description")] Gummi gummi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gummi);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(gummi);
        }

        // GET: Gummis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gummi = await _context.Gummis.SingleOrDefaultAsync(m => m.GummiId == id);
            if (gummi == null)
            {
                return NotFound();
            }
            return View(gummi);
        }

        // POST: Gummis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GummiId,Name,Price,Description")] Gummi gummi)
        {
            if (id != gummi.GummiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gummi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GummiExists(gummi.GummiId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(gummi);
        }

        // GET: Gummis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gummi = await _context.Gummis
                .SingleOrDefaultAsync(m => m.GummiId == id);
            if (gummi == null)
            {
                return NotFound();
            }

            return View(gummi);
        }

        // POST: Gummis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gummi = await _context.Gummis.SingleOrDefaultAsync(m => m.GummiId == id);
            _context.Gummis.Remove(gummi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool GummiExists(int id)
        {
            return _context.Gummis.Any(e => e.GummiId == id);
        }
    }
}
