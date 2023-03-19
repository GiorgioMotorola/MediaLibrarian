﻿using System;
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
    public class MovieModelsController : Controller
    {
        private readonly AppDbContext _context;

        public MovieModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MovieModels
        public async Task<IActionResult> Index()
        {
              return _context.Movie != null ? 
                          View(await _context.Movie.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Movie'  is null.");
        }

        // GET: MovieModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieModel == null)
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // GET: MovieModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovieModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Stars,Director,Writer,UserRating,Description,MPAA,RunTimeHours,RunTimeMinutes,ReleaseDate,Genre,GenreTwo,GenreThree,Image")] MovieModel movieModel)
        {
            if (ModelState.IsValid)
            {
                movieModel.Id = Guid.NewGuid();
                _context.Add(movieModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieModel);
        }

        // GET: MovieModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie.FindAsync(id);
            if (movieModel == null)
            {
                return NotFound();
            }
            return View(movieModel);
        }

        // POST: MovieModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Stars,Director,Writer,UserRating,Description,MPAA,RunTimeHours,RunTimeMinutes,ReleaseDate,Genre,GenreTwo,GenreThree,Image")] MovieModel movieModel)
        {
            if (id != movieModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieModelExists(movieModel.Id))
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
            return View(movieModel);
        }

        // GET: MovieModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movieModel = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieModel == null)
            {
                return NotFound();
            }

            return View(movieModel);
        }

        // POST: MovieModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'AppDbContext.Movie'  is null.");
            }
            var movieModel = await _context.Movie.FindAsync(id);
            if (movieModel != null)
            {
                _context.Movie.Remove(movieModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieModelExists(Guid id)
        {
          return (_context.Movie?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Movie == null)
            {
                return Problem("No Results Found");
            }

            var movies = from m in _context.Movie
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title!.Contains(searchString)
                || s.Stars!.Contains(searchString)
                || s.Director!.Contains(searchString) || s.Writer!.Contains(searchString)
                || s.ReleaseDate!.Contains(searchString));
            }



            return View(await movies.ToListAsync());
        }
    }
}
