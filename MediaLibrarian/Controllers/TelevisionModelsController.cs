using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaLibrarian.Data;
using MediaLibrarian.Models;

namespace MediaLibrarian.Controllers
{
    public class TelevisionModelsController : Controller
    {
        private readonly AppDbContext _context;

        public TelevisionModelsController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
              return _context.Televsion != null ? 
                          View(await _context.Televsion.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Televsion'  is null.");
        }

        
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Televsion == null)
            {
                return NotFound();
            }

            var televisionModel = await _context.Televsion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (televisionModel == null)
            {
                return NotFound();
            }

            return View(televisionModel);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Stars,UserRating,Description,YearStart,YearEnd,Seasons,Genre,GenreTwo,GenreThree,Image")] TelevisionModel televisionModel)
        {
            if (ModelState.IsValid)
            {
                televisionModel.Id = Guid.NewGuid();
                _context.Add(televisionModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(televisionModel);
        }

        
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Televsion == null)
            {
                return NotFound();
            }

            var televisionModel = await _context.Televsion.FindAsync(id);
            if (televisionModel == null)
            {
                return NotFound();
            }
            return View(televisionModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Stars,UserRating,Description,YearStart,YearEnd,Seasons,Genre,GenreTwo,GenreThree,Image")] TelevisionModel televisionModel)
        {
            if (id != televisionModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(televisionModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelevisionModelExists(televisionModel.Id))
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
            return View(televisionModel);
        }

        
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Televsion == null)
            {
                return NotFound();
            }

            var televisionModel = await _context.Televsion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (televisionModel == null)
            {
                return NotFound();
            }

            return View(televisionModel);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Televsion == null)
            {
                return Problem("No Results Found");
            }
            var televisionModel = await _context.Televsion.FindAsync(id);
            if (televisionModel != null)
            {
                _context.Televsion.Remove(televisionModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TelevisionModelExists(Guid id)
        {
          return (_context.Televsion?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Televsion == null)
            {
                return Problem("No Results Found");
            }

            var tv = from m in _context.Televsion
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                tv = tv.Where(s => s.Stars!.Contains(searchString)
                || s.Title!.Contains(searchString)
                || s.GenreThree!.Contains(searchString) || s.GenreTwo!.Contains(searchString)
                || s.Description!.Contains(searchString));
            }

            return View(await tv.ToListAsync());
        }
    }
}
