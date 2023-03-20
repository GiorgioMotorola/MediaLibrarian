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
    public class BookModelsController : Controller
    {
        private readonly AppDbContext _context;

        public BookModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BookModels
        public async Task<IActionResult> Index()
        {
              return _context.Book != null ? 
                          View(await _context.Book.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.TV'  is null.");
        }

        // GET: BookModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // GET: BookModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Writer,UserRating,ReleaseDate,Genre,GenreTwo,GenreThree,Image")] BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                bookModel.Id = Guid.NewGuid();
                _context.Add(bookModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookModel);
        }

        // GET: BookModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Book.FindAsync(id);
            if (bookModel == null)
            {
                return NotFound();
            }
            return View(bookModel);
        }

        // POST: BookModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description,Writer,UserRating,ReleaseDate,Genre,GenreTwo,GenreThree,Image")] BookModel bookModel)
        {
            if (id != bookModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookModelExists(bookModel.Id))
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
            return View(bookModel);
        }

        // GET: BookModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // POST: BookModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Book == null)
            {
                return Problem("Entity set 'AppDbContext.TV'  is null.");
            }
            var bookModel = await _context.Book.FindAsync(id);
            if (bookModel != null)
            {
                _context.Book.Remove(bookModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookModelExists(Guid id)
        {
          return (_context.Book?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Book == null)
            {
                return Problem("No Results Found");
            }

            var book = from m in _context.Book
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                book = book.Where(s => s.Writer!.Contains(searchString)
                || s.Title!.Contains(searchString)
                || s.GenreThree!.Contains(searchString) || s.GenreTwo!.Contains(searchString)
                || s.ReleaseDate!.Contains(searchString));
            }


            return View(await book.ToListAsync());
        }
    }
}
