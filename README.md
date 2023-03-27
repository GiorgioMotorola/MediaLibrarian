# MediaLibrarian
Media Librarian is a media aggregator for Movies, Music, Books, Video Games and TV Shows. Add and Edit your favorites, give them a rating or delete them all together. This Web App was built in C# using the MVC design pattern, Entity Framework to handle the entities with a SQL database all with Bootstrap for the front end.  

![image](https://user-images.githubusercontent.com/97712526/228086550-68d9c6fd-1ad9-4026-b530-5bc548cd96ea.png)
![image](https://user-images.githubusercontent.com/97712526/228086615-4dce04ef-4c1e-4bee-8b8b-63695ccea236.png)
![image](https://user-images.githubusercontent.com/97712526/228086662-ee85a6c4-7a93-4c27-8d62-9e1cc54ecde6.png)


<h3> SET UP </H3>

Step One: In "appsettings.json", add your connection string: 

```C#
{
  "ConnectionStrings": {
    "DefaultConnection": "ADD SQL CONNECTION STRING HERE"
  },


  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

Step Two: Use the Package Manager Console to Add-Migration:
![image](https://user-images.githubusercontent.com/97712526/228086003-c0ea86bb-9128-4c86-b3c9-b8bf316a06c4.png)

Step Three: Use the Package Manager Console to Update-Database:
![image](https://user-images.githubusercontent.com/97712526/228086085-3773d3fc-3890-46c1-a375-0280dd6f43fe.png)

Step Four: There is Seed Data ready to be added to your SQL Db. If you would like to add this data, open Powershell and enter the following: 
![image](https://user-images.githubusercontent.com/97712526/228086339-b5e2a8cc-bf4a-47e2-ae46-b6c21e54f8f4.png)


<h3>The following Code Kentucky requirements were met:</h3>

1. Used CRUD API methods in all controllers. See below for one example: 
```C#
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
```
2. Made Controllers Asynchronous. See below for one example: 
```C#
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
```       
 3. Add comments to your code explaining how you are using at least 2 of the solid principles. See below for both examples:  
```C#
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
```
```C#

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
```      
