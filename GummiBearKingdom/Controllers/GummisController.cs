using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;
using GummiBearKingdom.Models.Repositories;

namespace GummiBearKingdom.Controllers
{
    public class GummisController : Controller
    {

        private IGummiRepository _context;

        public GummisController(IGummiRepository repo = null)
        {
            if(repo == null)
            {
                _context = new EFGummiRepository();
            }
            else
            {
                _context = repo;
            }
        }


        // GET: Gummis
        public IActionResult Index()
        {
            return View(_context.Gummis.ToList());
        }

        // GET: Gummis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gummi = await _context.Gummis.Include(r => r.Reviews)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GummiId,Name,Price,Description")] Gummi gummi)
        {
            if (ModelState.IsValid)
            {
                _context.Create(gummi);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GummiId,Name,Price,Description")] Gummi gummi)
        {
            if (id != gummi.GummiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Edit(gummi);
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
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.Delete(id);
            return RedirectToAction("Index");
        }

        private bool GummiExists(int id)
        {
            return _context.Gummis.Any(e => e.GummiId == id);
        }
    }
}
