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
    public class LocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Location
        public async Task<IActionResult> Index()
        {
            var locationList = _context.AirsoftLocationModel.Where(x => x.Username == User.Identity.Name);
            return View(locationList);
        }

        // GET: Location/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AirsoftLocationModel == null)
            {
                return NotFound();
            }

            var airsoftLocationModel = await _context.AirsoftLocationModel
                .FirstOrDefaultAsync(m => m.ID == id && m.Username == User.Identity.Name);
            if (airsoftLocationModel == null)
            {
                return NotFound();
            }

            return View(airsoftLocationModel);
        }

        // GET: Location/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Rules,City,Country,Address,UserName")] AirsoftLocationModel airsoftLocationModel)
        {
            if (ModelState.IsValid)
            {
                airsoftLocationModel.ID = Guid.NewGuid();

                if (User.Identity.Name != null)
                {
                    airsoftLocationModel.Username = User.Identity.Name;
                }

                _context.Add(airsoftLocationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airsoftLocationModel);
        }

        // GET: Location/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AirsoftLocationModel == null)
            {
                return NotFound();
            }

            var airsoftLocationModel = await _context.AirsoftLocationModel.FindAsync(id);
            if (airsoftLocationModel == null)
            {
                return NotFound();
            }
            return View(airsoftLocationModel);
        }

        // POST: Location/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Description,Rules,City,Country,Address")] AirsoftLocationModel airsoftLocationModel)
        {
            if (id != airsoftLocationModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airsoftLocationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirsoftLocationModelExists(airsoftLocationModel.ID))
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
            return View(airsoftLocationModel);
        }

        // GET: Location/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AirsoftLocationModel == null)
            {
                return NotFound();
            }

            var airsoftLocationModel = await _context.AirsoftLocationModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (airsoftLocationModel == null)
            {
                return NotFound();
            }

            return View(airsoftLocationModel);
        }

        // POST: Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AirsoftLocationModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AirsoftLocationModel'  is null.");
            }
            var airsoftLocationModel = await _context.AirsoftLocationModel.FindAsync(id);
            if (airsoftLocationModel != null)
            {
                _context.AirsoftLocationModel.Remove(airsoftLocationModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirsoftLocationModelExists(Guid id)
        {
          return (_context.AirsoftLocationModel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
