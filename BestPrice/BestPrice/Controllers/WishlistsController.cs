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
    public class WishlistsController : Controller
    {
        private readonly prj666_192a03Context _context;

        public WishlistsController(prj666_192a03Context context)
        {
            _context = context;
        }

        // GET: Wishlists
        public async Task<IActionResult> Index()
        {
            var prj666_192a03Context = _context.Wishlists.Include(w => w.User);
            return View(await prj666_192a03Context.ToListAsync());
        }

        // GET: Wishlists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlists = await _context.Wishlists
                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wishlists == null)
            {
                return NotFound();
            }

            return View(wishlists);
        }

        // GET: Wishlists/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Wishlists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId")] Wishlists wishlists)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wishlists);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", wishlists.UserId);
            return View(wishlists);
        }

        // GET: Wishlists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlists = await _context.Wishlists.FindAsync(id);
            if (wishlists == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", wishlists.UserId);
            return View(wishlists);
        }

        // POST: Wishlists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId")] Wishlists wishlists)
        {
            if (id != wishlists.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wishlists);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WishlistsExists(wishlists.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", wishlists.UserId);
            return View(wishlists);
        }

        // GET: Wishlists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlists = await _context.Wishlists
                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wishlists == null)
            {
                return NotFound();
            }

            return View(wishlists);
        }

        // POST: Wishlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wishlists = await _context.Wishlists.FindAsync(id);
            _context.Wishlists.Remove(wishlists);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WishlistsExists(int id)
        {
            return _context.Wishlists.Any(e => e.Id == id);
        }
    }
}
