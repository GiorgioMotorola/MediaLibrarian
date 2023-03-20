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
    public class VideoGameModelsController : Controller
    {
        private readonly AppDbContext _context;

        public VideoGameModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: VideoGameModels
        public async Task<IActionResult> Index()
        {
              return _context.VideoGame != null ? 
                          View(await _context.VideoGame.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.VideoGame'  is null.");
        }

        // GET: VideoGameModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.VideoGame == null)
            {
                return NotFound();
            }

            var videoGameModel = await _context.VideoGame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoGameModel == null)
            {
                return NotFound();
            }

            return View(videoGameModel);
        }

        // GET: VideoGameModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoGameModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Company,Description,ReleaseDate,Platform,UserRating,ESRB,Genre,GenreTwo,GenreThree,Image")] VideoGameModel videoGameModel)
        {
            if (ModelState.IsValid)
            {
                videoGameModel.Id = Guid.NewGuid();
                _context.Add(videoGameModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoGameModel);
        }

        // GET: VideoGameModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.VideoGame == null)
            {
                return NotFound();
            }

            var videoGameModel = await _context.VideoGame.FindAsync(id);
            if (videoGameModel == null)
            {
                return NotFound();
            }
            return View(videoGameModel);
        }

        // POST: VideoGameModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Company,Description,ReleaseDate,Platform,UserRating,ESRB,Genre,GenreTwo,GenreThree,Image")] VideoGameModel videoGameModel)
        {
            if (id != videoGameModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoGameModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoGameModelExists(videoGameModel.Id))
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
            return View(videoGameModel);
        }

        // GET: VideoGameModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.VideoGame == null)
            {
                return NotFound();
            }

            var videoGameModel = await _context.VideoGame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoGameModel == null)
            {
                return NotFound();
            }

            return View(videoGameModel);
        }

        // POST: VideoGameModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.VideoGame == null)
            {
                return Problem("Entity set 'AppDbContext.VideoGame'  is null.");
            }
            var videoGameModel = await _context.VideoGame.FindAsync(id);
            if (videoGameModel != null)
            {
                _context.VideoGame.Remove(videoGameModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoGameModelExists(Guid id)
        {
          return (_context.VideoGame?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.VideoGame == null)
            {
                return Problem("No Results Found");
            }

            var vg = from m in _context.VideoGame
                     select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                vg = vg.Where(s => s.Platform!.Contains(searchString)
                || s.Title!.Contains(searchString)
                || s.GenreThree!.Contains(searchString) || s.GenreTwo!.Contains(searchString)
                || s.Description!.Contains(searchString));
            }


            return View(await vg.ToListAsync());
        }
    }
}
