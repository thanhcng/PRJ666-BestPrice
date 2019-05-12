using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestPrice.Models;

namespace BestPrice.Controllers
{
    public class SellersController : Controller
    {
        private readonly prj666_192a03Context _context;

        public SellersController(prj666_192a03Context context)
        {
            _context = context;
        }

        // GET: Sellers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sellers.ToListAsync());
        }

        // GET: Sellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellers = await _context.Sellers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sellers == null)
            {
                return NotFound();
            }

            return View(sellers);
        }

        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Link")] Sellers sellers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sellers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sellers);
        }

        // GET: Sellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellers = await _context.Sellers.FindAsync(id);
            if (sellers == null)
            {
                return NotFound();
            }
            return View(sellers);
        }

        // POST: Sellers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Link")] Sellers sellers)
        {
            if (id != sellers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sellers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellersExists(sellers.Id))
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
            return View(sellers);
        }

        // GET: Sellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellers = await _context.Sellers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sellers == null)
            {
                return NotFound();
            }

            return View(sellers);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sellers = await _context.Sellers.FindAsync(id);
            _context.Sellers.Remove(sellers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellersExists(int id)
        {
            return _context.Sellers.Any(e => e.Id == id);
        }
    }
}
