using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaldwellHotels.Data;
using CaldwellHotels.Models;

namespace CaldwellHotels.Controllers
{
    public class RoomStylesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomStylesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomStyles
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomStyles.ToListAsync());
        }

        // GET: RoomStyles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomStyle = await _context.RoomStyles
                .FirstOrDefaultAsync(m => m.StyleID == id);
            if (roomStyle == null)
            {
                return NotFound();
            }

            return View(roomStyle);
        }

        // GET: RoomStyles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomStyles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StyleID,BedroomDescription,BathroomDescription,KitchenDescription")] RoomStyle roomStyle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomStyle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomStyle);
        }

        // GET: RoomStyles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomStyle = await _context.RoomStyles.FindAsync(id);
            if (roomStyle == null)
            {
                return NotFound();
            }
            return View(roomStyle);
        }

        // POST: RoomStyles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StyleID,BedroomDescription,BathroomDescription,KitchenDescription")] RoomStyle roomStyle)
        {
            if (id != roomStyle.StyleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomStyle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomStyleExists(roomStyle.StyleID))
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
            return View(roomStyle);
        }

        // GET: RoomStyles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomStyle = await _context.RoomStyles
                .FirstOrDefaultAsync(m => m.StyleID == id);
            if (roomStyle == null)
            {
                return NotFound();
            }

            return View(roomStyle);
        }

        // POST: RoomStyles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomStyle = await _context.RoomStyles.FindAsync(id);
            _context.RoomStyles.Remove(roomStyle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomStyleExists(int id)
        {
            return _context.RoomStyles.Any(e => e.StyleID == id);
        }
    }
}
