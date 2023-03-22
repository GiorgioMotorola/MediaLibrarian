using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaLibrarian.Data;
using MediaLibrarian.Models;
using System.Numerics;

namespace MediaLibrarian.Controllers
{
    // This code follows the Dependency Inversion Principle (DIP).
    // The DIP states that high-level modules should not depend on low-level modules
    // but instead, they should both depend on abstractions. In this case, the BookModelsController is a high-level module, and the AppDbContext
    // is a low-level module. Instead of depending directly on the AppDbContext, the BookModelsController depends on an abstraction of it.
    //By injecting the AppDbContext through the constructor, the BookModelsController is not tightly coupled to a specific implementation
    //of the AppDbContext.This makes the controller easier to test, maintain,
    //and swap out the implementation of the AppDbContext without having to change the BookModelsController class.
    public class BookModelsController : Controller
    {
        private readonly AppDbContext _context;

        public BookModelsController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
              return _context.Book != null ? 
                          View(await _context.Book.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.TV'  is null.");
        }

        
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

        
        public IActionResult Create()
        {
            return View();
        }

        
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

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Book == null)
            {
                return Problem("No Results Found");
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


        //The Following code follows the Single Responsibility Principle (SRP).
        //This method does not violate the SRP because it only performs one task
        //which is to retrieve and filter data based on a user input. 
        //It does not have any other responsibilities. 
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
