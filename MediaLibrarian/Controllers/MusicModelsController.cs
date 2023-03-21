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
    public class MusicModelsController : Controller
    {
        private readonly AppDbContext _context;

        public MusicModelsController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
              return _context.Music != null ? 
                          View(await _context.Music.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Music'  is null.");
        }

        
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Music == null)
            {
                return NotFound();
            }

            var musicModel = await _context.Music
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musicModel == null)
            {
                return NotFound();
            }

            return View(musicModel);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Artist,AlbumName,ReleaseDate,Label,UserRating,NumberOfTracks,Genre,GenreTwo,GenreThree,Image")] MusicModel musicModel)
        {
            if (ModelState.IsValid)
            {
                musicModel.Id = Guid.NewGuid();
                _context.Add(musicModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicModel);
        }

        
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Music == null)
            {
                return NotFound();
            }

            var musicModel = await _context.Music.FindAsync(id);
            if (musicModel == null)
            {
                return NotFound();
            }
            return View(musicModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Artist,AlbumName,ReleaseDate,Label,UserRating,NumberOfTracks,Genre,GenreTwo,GenreThree,Image")] MusicModel musicModel)
        {
            if (id != musicModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicModelExists(musicModel.Id))
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
            return View(musicModel);
        }

        
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Music == null)
            {
                return NotFound();
            }

            var musicModel = await _context.Music
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musicModel == null)
            {
                return NotFound();
            }

            return View(musicModel);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Music == null)
            {
                return Problem("No Results Found");
            }
            var musicModel = await _context.Music.FindAsync(id);
            if (musicModel != null)
            {
                _context.Music.Remove(musicModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicModelExists(Guid id)
        {
          return (_context.Music?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Music == null)
            {
                return Problem("No Results Found");
            }

            var music = from m in _context.Music
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                music = music.Where(s => s.Artist!.Contains(searchString)
                || s.AlbumName!.Contains(searchString)
                || s.GenreThree!.Contains(searchString) || s.GenreTwo!.Contains(searchString)
                || s.ReleaseDate!.Contains(searchString));
            }


            return View(await music.ToListAsync());
        }
    }
}
