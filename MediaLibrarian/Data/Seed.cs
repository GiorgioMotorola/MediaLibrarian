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

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<MovieModel>()
                    {
                        new MovieModel()
                        {
                            Title = "The Departed",
                            Stars = "Leonardo Dicaprio, Matt Damon, Jack Nicholson",
                            Director = "Martin Scorsese",
                            Writer = "William Monahan",
                            Genre = Enums.MovieGenreCategory.Crime,
                            GenreTwo = "Drama",
                            GenreThree = "Thriller",
                            UserRating = 95,
                            Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 2,
                            RunTimeMinutes = 31,
                            ReleaseDate = "October 6, 2006",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/The%20Departed.png"
                         },

                        new MovieModel()
                        {
                            Title = "Blade Runner",
                            Stars = "Harrison Ford, Rutger Hauer, Sean Young",
                            Director = "Ridley Scott",
                            Writer = "Hampton Fancher, David Webb Peoples",
                            Genre = Enums.MovieGenreCategory.Action,
                            GenreTwo= "Drama",
                            GenreThree= "Sci-Fi",    
                            UserRating = 93,
                            Description = "A blade runner must pursue and terminate four replicants who stole a ship in space and have returned to Earth to find their creator.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 1,
                            RunTimeMinutes = 57,
                            ReleaseDate = "June 25, 1982",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Blade%20Runner.png"
                         },

                        new MovieModel()
                        {
                            Title = "Spotlight",
                            Stars = "Mark Ruffalo, Michael Keaton, Rachel McAdams",
                            Director = "Tom McCarthy",
                            Writer = "Josh Singer, Tom McCarthy",
                            Genre = Enums.MovieGenreCategory.Drama,
                            GenreTwo= "Biography",
                            GenreThree= "Drama",
                            UserRating = 96,
                            Description = "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 2,
                            RunTimeMinutes = 9,
                            ReleaseDate = "February 23, 2016",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Spotlight.png"
                         },


                        new MovieModel()
                        {
                            Title = "Heat",
                            Stars = "Al Pacino, Robert De Niro, Val Kilmer",
                            Director = "Michael Mann",
                            Writer = "Michael Mann",
                            Genre = Enums.MovieGenreCategory.Action,
                            GenreTwo = "Crime",
                            GenreThree = "Drama",
                            UserRating = 100,
                            Description = "A group of high-end professional thieves start to feel the heat from the LAPD when they unknowingly leave a clue at their latest heist.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 2,
                            RunTimeMinutes = 50,
                            ReleaseDate = "December 15, 1995",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Heat.png"
                         },

                        new MovieModel()
                        {
                            Title = "Before Sunset",
                            Stars = "Ethan Hawke, Julie Delphy",
                            Director = "Richard Linklater",
                            Writer = "Richard Linklater, Julie Delpy, Ethan Hawke",
                            Genre = Enums.MovieGenreCategory.Drama,
                            GenreTwo= "Romance",
                            UserRating = 97,
                            Description = "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 1 ,
                            RunTimeMinutes = 20,
                            ReleaseDate = "July 2, 2004",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Before%20Sunset.png"
                         },


                        new MovieModel()
                        {
                            Title = "Jaws",
                            Stars = "Roy Scheider, Robert Shaw, Richard Dreyfuss",
                            Director = "Steven Spielberg",
                            Writer = "Peter Benchley",
                            Genre = Enums.MovieGenreCategory.Thriller,
                            GenreTwo = "Thriller",
                            UserRating = 90,
                            Description = "When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.",
                            MPAA = Enums.MPAARatingCategory.PG,
                            RunTimeHours = 2,
                            RunTimeMinutes = 4,
                            ReleaseDate = "June 20, 1975",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Jaws.png"
                         },

                        new MovieModel()
                        {
                            Title = "No Country for Old Men",
                            Stars = "Tommy Lee Jones, Javier Bardem, Josh Brolin",
                            Director = "Joel Coen, Ethan Coen",
                            Writer = "Joel Coen, Ethan Coen",
                            Genre = Enums.MovieGenreCategory.Crime,
                            GenreTwo = "Drama",
                            GenreThree = "Thriller",
                            UserRating = 94,
                            Description = "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 1,
                            RunTimeMinutes = 2,
                            ReleaseDate = "November 9, 2007",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/No%20Country.png"
                         },

                        new MovieModel()
                        {
                            Title = "Ghost Dog: The Way of the Samurai",
                            Stars = "Forest Whitaker, Henry Silva, John Tormey",
                            Director = "Jim Jarmusch",
                            Writer = "Jim Jarmusch",
                            Genre = Enums.MovieGenreCategory.Crime,
                            GenreTwo = "Drama",
                            UserRating = 75,
                            Description = "An African-American Mafia hit man who models himself after the samurai of old finds himself targeted for death by the mob",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 1,
                            RunTimeMinutes = 56,
                            ReleaseDate = "March 3, 2000",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Ghost%20Dog.png"
                         },


                        new MovieModel()
                        {
                            Title = "The Thing",
                            Stars = "Kurt Russell, Wilford Brimley, Keith David",
                            Director = "John Carpenter",
                            Writer = "Bill Lancaster",
                            Genre = Enums.MovieGenreCategory.Horror,
                            GenreTwo = "Mystery",
                            GenreThree = "Sci-Fi",
                            UserRating = 89,
                            Description = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 1,
                            RunTimeMinutes= 49,
                            ReleaseDate = "June 25, 1982",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/The%20Thing.png"
                         },

                        new MovieModel()
                        {
                            Title = "Do The Right Thing",
                            Stars = "Danny Aiello, Ossie Davis, Ruby Dee",
                            Director = "Spike Lee",
                            Writer = "Spike Lee",
                            Genre = Enums.MovieGenreCategory.Drama,
                            GenreTwo = "Comedy",
                            UserRating = 85,
                            Description = "On the hottest day of the year on a street in the Bedford-Stuyvesant section of Brooklyn, everyone's hate and bigotry smolders and builds until it explodes into violence.",
                            MPAA = Enums.MPAARatingCategory.R,
                            RunTimeHours = 2,
                            RunTimeMinutes = 00,
                            ReleaseDate = "July 21, 1989",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Do%20The%20Right%20Thing.png"
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
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/MoviePosters/Surf%20Ninjas.png"
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
                            Artist = "Fleetwood Mac",
                            AlbumName = "Tusk",
                            ReleaseDate = "October 12, 1979",
                            Label = "Warner Bros",
                            UserRating = 100,
                            NumberOfTracks = 20,
                            Genre = Enums.MusicGenreCategory.Rock,
                            GenreTwo = "AOR",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/Tusk.jpg",

                        },

                        new MusicModel()
                        {
                            Artist = "The Replacements",
                            AlbumName = "Let It Be",
                            ReleaseDate = "October 2, 1984",
                            Label = "Twin/Tone",
                            UserRating = 100,
                            NumberOfTracks = 11,
                            Genre = Enums.MusicGenreCategory.Rock,
                            GenreTwo = "Alternative Rock",
                            GenreThree = "Punk",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/Tusk.jpg",

                        },

                    });
                    context.SaveChanges();
                }
                
                
            }
        }
    }
}
