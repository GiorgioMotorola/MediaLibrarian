using MediaLibrarian.Models;
using System;

namespace MediaLibrarian.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        new MovieModel()
                        {
                            Title = "The Departed",
                            Stars = "Leonardo Dicaprio, Matt Damon, Jack Nicholson",
                            Director = "Martin Scorsese",
                            Writer = "William Monahan",
                            Genre = "Crime, Drama, Thriller",
                            UserRating = 9.5,
                            Plot = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                            MPAARating = "R",
                            RunTime= "2h 31m",
                            ReleaseYear = 2006,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "Blade Runner",
                            Stars = "Harrison Ford, Rutger Hauer, Sean Young",
                            Director = "Ridley Scott",
                            Writer = "Hampton Fancher, David Webb Peoples",
                            Genre = "Action, Drama, Sci-Fi",
                            UserRating = 9.3,
                            Plot = "A blade runner must pursue and terminate four replicants who stole a ship in space and have returned to Earth to find their creator.",
                            MPAARating = "R",
                            RunTime= "1h 57m",
                            ReleaseYear = 1982,
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MoviesAndFilmWebApp/master/MoviesAndFilmWebApp/Posters/Blade%20Runner.png"
                         },

                        new MovieModel()
                        {
                            Title = "Spotlight",
                            Stars = "Mark Ruffalo, Michael Keaton, Rachel McAdams",
                            Director = "Tom McCarthy",
                            Writer = "Josh Singer, Tom McCarthy",
                            Genre = "Biography, Crime, Drama",
                            UserRating = 9.6,
                            Plot = "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.",
                            MPAARating = "R",
                            RunTime= "2h 9m",
                            ReleaseYear = 2015,
                            Image = ""
                         },


                        new MovieModel()
                        {
                            Title = "Heat",
                            Stars = "Al Pacino, Robert De Niro, Val Kilmer",
                            Director = "Michael Mann",
                            Writer = "Michael Mann",
                            Genre = "Action, Crime, Drama",
                            UserRating = 10.0,
                            Plot = "A group of high-end professional thieves start to feel the heat from the LAPD when they unknowingly leave a clue at their latest heist.",
                            MPAARating = "R",
                            RunTime= "2h 50m",
                            ReleaseYear = 1995,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "Before Sunset",
                            Stars = "Ethan Hawke, Julie Delphy",
                            Director = "Richard Linklater",
                            Writer = "Richard Linklater, Julie Delpy, Ethan Hawke",
                            Genre = "Drama, Romance",
                            UserRating = 9.7,
                            Plot = "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                            MPAARating = "R",
                            RunTime= "1h 20m",
                            ReleaseYear = 2004,
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MoviesAndFilmWebApp/master/MoviesAndFilmWebApp/Posters/Before%20Sunset.png"
                         },


                        new MovieModel()
                        {
                            Title = "Jaws",
                            Stars = "Roy Scheider, Robert Shaw, Richard Dreyfuss",
                            Director = "Steven Spielberg",
                            Writer = "Peter Benchley",
                            Genre = "Adventure, Thriller",
                            UserRating = 9.0,
                            Plot = "When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.",
                            MPAARating = "PG",
                            RunTime= "2h 4m",
                            ReleaseYear = 1975,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "No Country for Old Men",
                            Stars = "Tommy Lee Jones, Javier Bardem, Josh Brolin",
                            Director = "Joel Coen, Ethan Coen",
                            Writer = "Joel Coen, Ethan Coen",
                            Genre = "Crime, Drama, Thriller",
                            UserRating = 9.4,
                            Plot = "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",
                            MPAARating = "R",
                            RunTime= "1h 2m",
                            ReleaseYear = 2007,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "Ghost Dog: The Way of the Samurai",
                            Stars = "Forest Whitaker, Henry Silva, John Tormey",
                            Director = "Jim Jarmusch",
                            Writer = "Jim Jarmusch",
                            Genre = "Crime, Drama",
                            UserRating = 7.5,
                            Plot = "An African-American Mafia hit man who models himself after the samurai of old finds himself targeted for death by the mob",
                            MPAARating = "R",
                            RunTime= "1h 56m",
                            ReleaseYear = 1999,
                            Image = ""
                         },


                        new MovieModel()
                        {
                            Title = "The Thing",
                            Stars = "Kurt Russell, Wilford Brimley, Keith David",
                            Director = "John Carpenter",
                            Writer = "Bill Lancaster",
                            Genre = "Horror, Mystery, Sci-Fi",
                            UserRating = 8.9,
                            Plot = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.",
                            MPAARating = "R",
                            RunTime= "1h 49m",
                            ReleaseYear = 1982,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "Do The Right Thing",
                            Stars = "Danny Aiello, Ossie Davis, Ruby Dee",
                            Director = "Spike Lee",
                            Writer = "Spike Lee",
                            Genre = "Comedy, Drama",
                            UserRating = 8.5,
                            Plot = "On the hottest day of the year on a street in the Bedford-Stuyvesant section of Brooklyn, everyone's hate and bigotry smolders and builds until it explodes into violence.",
                            MPAARating = "R",
                            RunTime= "2h",
                            ReleaseYear = 1989,
                            Image = ""
                         },

                        new MovieModel()
                        {
                            Title = "Surf Ninjas",
                            Stars = "Ernie Reyes Sr, Rob Schneider, Ernie Reyes Jr",
                            Director = "Neal Israel",
                            Writer = "Dan Gordon",
                            Genre = Enums.MovieGenreCategory.Action,
                            GenreTwo = "Comedy",
                            GenreThree = "Family",
                            UserRating = 60,
                            Description = "Two boys learn from a mysterious warrior that they are the heirs to the throne of Patusan and set out to overthrow the current monarchy.",
                            MPAA = Enums.MPAARatingCategory.PG,
                            RunTimeHours = 1,
                            RunTimeMinutes = 27,
                            ReleaseDate = "August 20, 1993",
                            Image = ""
                         },


                    });
                    context.SaveChanges();
                }
                if (!context.Music.Any())
                {
                    context.Music.AddRange(new List<MusicModel>()
                    {
                        new MusicModel()
                        {
                            Artist = "",
                            AlbumName = "",
                            ReleaseDate = ,
                            Label = "",
                            UserRating = "",
                            Genre = ,
                            GenreTwo = ,
                            GenreThree = ,
                            Image = ,

                            },
                       new MusicModel()
                        {
                            Artist = "",
                            AlbumName = "",
                            ReleaseDate = ,
                            Label = "",
                            UserRating = "",
                            Genre = ,
                            GenreTwo = ,
                            GenreThree = ,
                            Image = ,

                            },
                    });
                    context.SaveChanges();
                }
                
                
            }
        }
    }
}
