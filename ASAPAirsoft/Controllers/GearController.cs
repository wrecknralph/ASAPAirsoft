using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASAPAirsoft.Data;
using ASAPAirsoft.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASAPAirsoft.Controllers
{
    [Authorize]
    public class GearController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GearController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gear
        public async Task<IActionResult> Index()
        {
              return _context.AirsoftGearModel != null ? 
                          View(await _context.AirsoftGearModel.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.AirsoftGearModel'  is null.");
        }

        // GET: Gear/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AirsoftGearModel == null)
            {
                return NotFound();
            }

            var airsoftGearModel = await _context.AirsoftGearModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (airsoftGearModel == null)
            {
                return NotFound();
            }

            return View(airsoftGearModel);
        }

        // GET: Gear/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gear/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Type,Link")] AirsoftGearModel airsoftGearModel)
        {
            if (ModelState.IsValid)
            {
                airsoftGearModel.ID = Guid.NewGuid();
                _context.Add(airsoftGearModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airsoftGearModel);
        }

        // GET: Gear/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AirsoftGearModel == null)
            {
                return NotFound();
            }

            var airsoftGearModel = await _context.AirsoftGearModel.FindAsync(id);
            if (airsoftGearModel == null)
            {
                return NotFound();
            }
            return View(airsoftGearModel);
        }

        // POST: Gear/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Description,Type,Link")] AirsoftGearModel airsoftGearModel)
        {
            if (id != airsoftGearModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airsoftGearModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirsoftGearModelExists(airsoftGearModel.ID))
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
            return View(airsoftGearModel);
        }

        // GET: Gear/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AirsoftGearModel == null)
            {
                return NotFound();
            }

            var airsoftGearModel = await _context.AirsoftGearModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (airsoftGearModel == null)
            {
                return NotFound();
            }

            return View(airsoftGearModel);
        }

        // POST: Gear/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AirsoftGearModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AirsoftGearModel'  is null.");
            }
            var airsoftGearModel = await _context.AirsoftGearModel.FindAsync(id);
            if (airsoftGearModel != null)
            {
                _context.AirsoftGearModel.Remove(airsoftGearModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirsoftGearModelExists(Guid id)
        {
          return (_context.AirsoftGearModel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
