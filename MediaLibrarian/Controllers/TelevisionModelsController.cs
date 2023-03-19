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

        // GET: TelevisionModels
        public async Task<IActionResult> Index()
        {
              return _context.Televsion != null ? 
                          View(await _context.Televsion.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Televsion'  is null.");
        }

        // GET: TelevisionModels/Details/5
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

        // GET: TelevisionModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TelevisionModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: TelevisionModels/Edit/5
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

        // POST: TelevisionModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: TelevisionModels/Delete/5
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

        // POST: TelevisionModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Televsion == null)
            {
                return Problem("Entity set 'AppDbContext.Televsion'  is null.");
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
    }
}
