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
    public class GunController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GunController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gun
        public async Task<IActionResult> Index()
        {
            var gunsList = _context.AirsoftGunModel.Where(x => x.Username == User.Identity.Name);
            return View(gunsList);
        }

        // GET: Gun/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AirsoftGunModel == null)
            {
                return NotFound();
            }

            var airsoftGunModel = await _context.AirsoftGunModel
                .FirstOrDefaultAsync(m => m.ID == id && m.Username == User.Identity.Name);
            if (airsoftGunModel == null)
            {
                return NotFound();
            }

            return View(airsoftGunModel);
        }

        // GET: Gun/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gun/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Type,Link,UserName")] AirsoftGunModel airsoftGunModel)
        {            
            if (ModelState.IsValid)
            {
                airsoftGunModel.ID = Guid.NewGuid();
                
                if (User.Identity.Name != null)
                {
                    airsoftGunModel.Username = User.Identity.Name;
                }
                
                _context.Add(airsoftGunModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airsoftGunModel);
        }

        // GET: Gun/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AirsoftGunModel == null)
            {
                return NotFound();
            }

            var airsoftGunModel = await _context.AirsoftGunModel.FindAsync(id);
            if (airsoftGunModel == null)
            {
                return NotFound();
            }
            return View(airsoftGunModel);
        }

        // POST: Gun/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Description,Type,Link")] AirsoftGunModel airsoftGunModel)
        {
            if (id != airsoftGunModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airsoftGunModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirsoftGunModelExists(airsoftGunModel.ID))
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
            return View(airsoftGunModel);
        }

        // GET: Gun/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AirsoftGunModel == null)
            {
                return NotFound();
            }

            var airsoftGunModel = await _context.AirsoftGunModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (airsoftGunModel == null)
            {
                return NotFound();
            }

            return View(airsoftGunModel);
        }

        // POST: Gun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AirsoftGunModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AirsoftGunModel'  is null.");
            }
            var airsoftGunModel = await _context.AirsoftGunModel.FindAsync(id);
            if (airsoftGunModel != null)
            {
                _context.AirsoftGunModel.Remove(airsoftGunModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirsoftGunModelExists(Guid id)
        {
          return (_context.AirsoftGunModel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
