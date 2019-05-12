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
    public class SearchHistoriesController : Controller
    {
        private readonly prj666_192a03Context _context;

        public SearchHistoriesController(prj666_192a03Context context)
        {
            _context = context;
        }

        // GET: SearchHistories
        public async Task<IActionResult> Index()
        {
            var prj666_192a03Context = _context.SearchHistories.Include(s => s.User);
            return View(await prj666_192a03Context.ToListAsync());
        }

        // GET: SearchHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var searchHistories = await _context.SearchHistories
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (searchHistories == null)
            {
                return NotFound();
            }

            return View(searchHistories);
        }

        // GET: SearchHistories/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: SearchHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date,UserId")] SearchHistories searchHistories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(searchHistories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", searchHistories.UserId);
            return View(searchHistories);
        }

        // GET: SearchHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var searchHistories = await _context.SearchHistories.FindAsync(id);
            if (searchHistories == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", searchHistories.UserId);
            return View(searchHistories);
        }

        // POST: SearchHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date,UserId")] SearchHistories searchHistories)
        {
            if (id != searchHistories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(searchHistories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SearchHistoriesExists(searchHistories.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", searchHistories.UserId);
            return View(searchHistories);
        }

        // GET: SearchHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var searchHistories = await _context.SearchHistories
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (searchHistories == null)
            {
                return NotFound();
            }

            return View(searchHistories);
        }

        // POST: SearchHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var searchHistories = await _context.SearchHistories.FindAsync(id);
            _context.SearchHistories.Remove(searchHistories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SearchHistoriesExists(int id)
        {
            return _context.SearchHistories.Any(e => e.Id == id);
        }
    }
}
