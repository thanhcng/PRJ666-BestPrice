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
    public class WishlistProductController : Controller
    {
        private readonly prj666_192a03Context _context;

        public WishlistProductController(prj666_192a03Context context)
        {
            _context = context;
        }

        // GET: WishlistProduct
        public async Task<IActionResult> Index()
        {
            var prj666_192a03Context = _context.WishlistProduct.Include(w => w.Product).Include(w => w.Wishlist);
            return View(await prj666_192a03Context.ToListAsync());
        }

        // GET: WishlistProduct/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlistProduct = await _context.WishlistProduct
                .Include(w => w.Product)
                .Include(w => w.Wishlist)
                .SingleOrDefaultAsync(m => m.WishlistId == id);
            if (wishlistProduct == null)
            {
                return NotFound();
            }

            return View(wishlistProduct);
        }

        // GET: WishlistProduct/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            ViewData["WishlistId"] = new SelectList(_context.Wishlists, "Id", "Id");
            return View();
        }

        // POST: WishlistProduct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WishlistId,ProductId")] WishlistProduct wishlistProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wishlistProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", wishlistProduct.ProductId);
            ViewData["WishlistId"] = new SelectList(_context.Wishlists, "Id", "Id", wishlistProduct.WishlistId);
            return View(wishlistProduct);
        }

        // GET: WishlistProduct/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlistProduct = await _context.WishlistProduct.SingleOrDefaultAsync(m => m.WishlistId == id);
            if (wishlistProduct == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", wishlistProduct.ProductId);
            ViewData["WishlistId"] = new SelectList(_context.Wishlists, "Id", "Id", wishlistProduct.WishlistId);
            return View(wishlistProduct);
        }

        // POST: WishlistProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WishlistId,ProductId")] WishlistProduct wishlistProduct)
        {
            if (id != wishlistProduct.WishlistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wishlistProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WishlistProductExists(wishlistProduct.WishlistId))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", wishlistProduct.ProductId);
            ViewData["WishlistId"] = new SelectList(_context.Wishlists, "Id", "Id", wishlistProduct.WishlistId);
            return View(wishlistProduct);
        }

        // GET: WishlistProduct/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlistProduct = await _context.WishlistProduct
                .Include(w => w.Product)
                .Include(w => w.Wishlist)
                .SingleOrDefaultAsync(m => m.WishlistId == id);
            if (wishlistProduct == null)
            {
                return NotFound();
            }

            return View(wishlistProduct);
        }

        // POST: WishlistProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wishlistProduct = await _context.WishlistProduct.SingleOrDefaultAsync(m => m.WishlistId == id);
            _context.WishlistProduct.Remove(wishlistProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WishlistProductExists(int id)
        {
            return _context.WishlistProduct.Any(e => e.WishlistId == id);
        }
    }
}
