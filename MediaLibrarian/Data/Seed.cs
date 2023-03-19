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
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/LetItBe.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "2814",
                            AlbumName = "新しい日の誕生",
                            ReleaseDate = "January 21, 2015",
                            Label = "Dream Catalogue",
                            UserRating = 100,
                            NumberOfTracks = 8,
                            Genre = Enums.MusicGenreCategory.Ambient,
                            GenreTwo = "Vaporwave",
                            GenreThree = "Dreampunk",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/2814.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Everything Everything",
                            AlbumName = "Get To Heaven",
                            ReleaseDate = "June 15, 2015",
                            Label = "RCA",
                            UserRating = 100,
                            NumberOfTracks = 11,
                            Genre = Enums.MusicGenreCategory.Pop,
                            GenreTwo = "Progressive Pop",
                            GenreThree = "Indie Rock",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/GetToHeaven.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Conway the Machine",
                            AlbumName = "God Don't Make Mistakes",
                            ReleaseDate = "February 25, 2022",
                            Label = "Shady",
                            UserRating = 85,
                            NumberOfTracks = 12,
                            Genre = Enums.MusicGenreCategory.HipHop,
                            GenreTwo = "Conscious Hip Hop",
                            GenreThree = "Gansta Rap",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/GotDontMakeMistakes.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Hiroshi Yoshimura",
                            AlbumName = "Green",
                            ReleaseDate = "March 20, 1986",
                            Label = "N/A",
                            UserRating = 100,
                            NumberOfTracks = 8,
                            Genre = Enums.MusicGenreCategory.Ambient,
                            GenreTwo = "New Age",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/Green.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Gram Parsons",
                            AlbumName = "Grievous Angel",
                            ReleaseDate = "January 1, 1974",
                            Label = "Reprise",
                            UserRating = 100,
                            NumberOfTracks = 9,
                            Genre = Enums.MusicGenreCategory.Country,
                            GenreTwo = "Alternative Country",
                            GenreThree = "Singer-Songwriter",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/Grevious.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Brian Eno & David Byrne",
                            AlbumName = "My Life in the Bush of Ghosts",
                            ReleaseDate = "February 1, 1981",
                            Label = "Sire",
                            UserRating = 100,
                            NumberOfTracks = 11,
                            Genre = Enums.MusicGenreCategory.Rock,
                            GenreTwo = "Experimental Rock",
                            GenreThree = "Art Rock",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/MyLifeBush.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Raekwon",
                            AlbumName = "Only Built 4 Cuban Linx...",
                            ReleaseDate = "August 1, 1995",
                            Label = "Loud",
                            UserRating = 100,
                            NumberOfTracks = 18,
                            Genre = Enums.MusicGenreCategory.HipHop,
                            GenreTwo = "East Coast Hip Hop",
                            GenreThree = "Boom Bap",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/OnlyBuilt.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Tim Hecker",
                            AlbumName = "Ravedeath, 1972",
                            ReleaseDate = "February 14, 2011",
                            Label = "Kranky",
                            UserRating = 85,
                            NumberOfTracks = 12,
                            Genre = Enums.MusicGenreCategory.Ambient,
                            GenreTwo = "Drone",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/RaveDeath.jpg",

                        },
                        new MusicModel()
                        {
                            Artist = "Fuming Mouth",
                            AlbumName = "The Grand Descent",
                            ReleaseDate = "June 7, 2019",
                            Label = "Triple-B Records",
                            UserRating = 80,
                            NumberOfTracks = 12,
                            Genre = Enums.MusicGenreCategory.Metal,
                            GenreTwo = "Death Metal",
                            GenreThree = "Hardcore",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/AlbumCovers/TheGrandDe.jpg",

                        },

                    });
                    context.SaveChanges();
                }

                if (!context.Book.Any())
                {
                    context.Book.AddRange(new List<BookModel>()
                    {
                        new BookModel()
                        {
                            Title = "1491: New Revelations of the Americas Before Columbus",
                            Description = "In this groundbreaking work of science, history, and archaeology, Charles C. Mann radically alters our understanding of the Americas before the arrival of Columbus in 1492.",
                            Writer = "Charles C. Mann",
                            UserRating = 90,
                            ReleaseDate = "August 9, 2005",
                            Genre = Enums.BookGenreCategory.NonFiction,
                            GenreTwo = "History",
                            GenreThree = "Anthropology",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/1491.jpg",
                        },

                        new BookModel()
                        {
                            Title = "A Confederacy of Dunces",
                            Description = "A Confederacy of Dunces is a rambling, aimless, comedic novel centered on Ignatius J. Reilly, a buffoonish overweight man-child with poor fashion sense, worse social skills, and deplorable hygiene.",
                            Writer = "John Kennedy Toole",
                            UserRating = 80,
                            ReleaseDate = "May 1, 1980",
                            Genre = Enums.BookGenreCategory.Fiction,
                            GenreTwo = "Humor",
                            GenreThree = "Classics",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/Confed.jpg",
                        },

                        new BookModel()
                        {
                            Title = "Don Quixote",
                            Description = "Don Quixote has become so entranced by reading chivalric romances that he determines to become a knight-errant himself. In the company of his faithful squire, Sancho Panza, his exploits blossom in all sorts of wonderful ways. While Quixote's fancy often leads him astray—he tilts at windmills, imagining them to be giants—Sancho acquires cunning and a certain sagacity.",
                            Writer = "Miguel de Cervantes Saavedra",
                            UserRating = 85,
                            ReleaseDate = "January 1, 1605",
                            Genre = Enums.BookGenreCategory.Fiction,
                            GenreTwo = "Classics",
                            GenreThree = "Spanish Literature",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/Don%20Quixote.jpg",
                        },

                        new BookModel()
                        {
                            Title = "Dune",
                            Description = "Set on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the “spice” melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for...",
                            Writer = "Frank Herbert",
                            UserRating = 91,
                            ReleaseDate = "June 1, 1965",
                            Genre = Enums.BookGenreCategory.SciFi,
                            GenreTwo = "Fiction",
                            GenreThree = "Fantasy",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/Dune.jpg",
                        },

                        new BookModel()
                        {
                            Title = "The Lies of Locke Lamora",
                            Description = "An orphan’s life is harsh—and often short—in the mysterious island city of Camorr. But young Locke Lamora dodges death and slavery, becoming a thief under the tutelage of a gifted con artist. As leader of the band of light-fingered brothers known as the Gentleman Bastards, Locke is soon infamous, fooling even the underworld’s most feared ruler. But in the shadows lurks someone still more ambitious and deadly. Faced with a bloody coup that threatens to destroy everyone and everything that holds meaning in his mercenary life, Locke vows to beat the enemy at his own brutal game—or die trying.",
                            Writer = "Scott Lynch",
                            UserRating = 100,
                            ReleaseDate = "June 1, 2006",
                            Genre = Enums.BookGenreCategory.Fantasy,
                            GenreTwo = "Fiction",
                            GenreThree = "Adventure",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/LockeLamora.png",
                        },

                        new BookModel()
                        {
                            Title = "Meet Me in the Bathroom: Rebirth and Rock and Roll in New York City 2001-2011",
                            Description = "An intriguing oral history of the post-9/11 decline of the old-guard music industry and rebirth of the New York rock scene, led by a group of iconoclastic rock bands.",
                            Writer = "Lizzy Goodman",
                            UserRating = 100,
                            ReleaseDate = "May 23, 2017",
                            Genre = Enums.BookGenreCategory.NonFiction,
                            GenreTwo = "Music",
                            GenreThree = "History",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/MeetMeIn.jpg",
                        },

                        new BookModel()
                        {
                            Title = "Trouble Boys: The True Story of the Replacements",
                            Description = "Trouble Boys is the first definitive, no-holds-barred biography of one of the last great bands of the twentieth century: The Replacements. With full participation from reclusive singer and chief songwriter Paul Westerberg, bassist Tommy Stinson, guitarist Slim Dunlap, and the family of late band co-founder Bob Stinson, author Bob Mehr is able to tell the real story of this highly influential group, capturing their chaotic, tragic journey from the basements of Minneapolis to rock legend.",
                            Writer = "Bob Mehr",
                            UserRating = 100,
                            ReleaseDate = "March 1, 2016",
                            Genre = Enums.BookGenreCategory.NonFiction,
                            GenreTwo = "Music",
                            GenreThree = "History",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/Troubled%20Boys.jpg",
                        },

                        new BookModel()
                        {
                            Title = "Undaunted Courage: The Pioneering First Mission to Explore America's Wild Frontier",
                            Description = "'This was much more than a bunch of guys out on an exploring and collecting expedition. This was a military expedition into hostile territory'.",
                            Writer = "Stephen E. Ambrose",
                            UserRating = 85,
                            ReleaseDate = "February 15, 1996",
                            Genre = Enums.BookGenreCategory.NonFiction,
                            GenreTwo = "Biography",
                            GenreThree = "History",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/Undaunted.jpg",
                        },

                         new BookModel()
                        {
                            Title = "The Crying of Lot 49",
                            Description = "Suffused with rich satire, chaotic brilliance, verbal turbulence and wild humor, The Crying of Lot 49 opens as Oedipa Maas discovers that she has been made executrix of a former lover's estate.",
                            Writer = "Thomas Pynchon",
                            UserRating = 75,
                            ReleaseDate = "January 1, 1966",
                            Genre = Enums.BookGenreCategory.Fiction,
                            GenreTwo = "Classics",
                            GenreThree = "Novels",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/lot%2049.jpg",
                        },

                         new BookModel()
                        {
                            Title = "A People's History of the United States",
                            Description = "In the book, Zinn presented a different side of history from the more traditional \"fundamental nationalist glorification of country\".",
                            Writer = "Howard Zinn",
                            UserRating = 91,
                            ReleaseDate = "January 1, 1980",
                            Genre = Enums.BookGenreCategory.NonFiction,
                            GenreTwo = "History",
                            GenreThree = "Politics",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/BookCovers/peoples%20histroy.jpg",
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Televsion.Any())
                {
                    context.Televsion.AddRange(new List<TelevisionModel>()
                    {
                        new TelevisionModel()
                        {
                         
                            Title = "Barry",
                            Description = "A hit man from the Midwest moves to Los Angeles and gets caught up in the city's theatre arts scene.",
                            Stars = "Bill Hader, Stephen Root, Sarah Goldberg",
                            UserRating = 84,
                            YearStart = 2018,
                            YearEnd = 2023,
                            Seasons = 4,
                            Genre = Enums.TelevisionGenreCategory.Action,
                            GenreTwo = "Comedy",
                            GenreThree = "Crime",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Barry.jpg",
                        
                        },

                        new TelevisionModel()
                        {

                            Title = "I Think You Should Leave with Tim Robinson",
                            Description = "In this new sketch show, Tim Robinson and his guests spend each segment driving someone to the point of needing--or desperately wanting--to leave.",
                            Stars = "Tim Robinson, Sam Richardson, Patti Harrison",
                            UserRating = 100,
                            YearStart = 2019,
                            Seasons = 3,
                            Genre = Enums.TelevisionGenreCategory.Comedy,
                            GenreTwo = "Sketch",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/IThinkYou.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Mad Men",
                            Description = "A drama about one of New York's most prestigious ad agencies at the beginning of the 1960s, focusing on one of the firm's most mysterious but extremely talented ad executives, Donald Draper.",
                            Stars = "Jon Hamm, Elisabeth Moss, Vincent Kartheiser",
                            UserRating = 100,
                            YearStart = 2007,
                            YearEnd = 2015,
                            Seasons = 7,
                            Genre = Enums.TelevisionGenreCategory.Drama,
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/MadMen.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Midnight Mass",
                            Description = "An isolated island community experiences miraculous events - and frightening omens - after the arrival of a charismatic, mysterious young priest.",
                            Stars = "Kate Siegel, Zach Gilford, Kristin Lehman",
                            UserRating = 77,
                            YearStart = 2021,
                            Seasons = 1,
                            Genre = Enums.TelevisionGenreCategory.Horror,
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Midnight%20Mass.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Nathan for You",
                            Description = "Nathan Fielder uses his business degree and life experiences to help real small businesses turn a profit. But because of his unorthodox approach, Nathan's genuine efforts to do good often draw real people into an experience far beyond what they signed up for.",
                            Stars = "Nathan Fielder, Anthony Filosa, Michael Koman",
                            UserRating = 95,
                            YearStart = 2013,
                            YearEnd = 2017,
                            Seasons = 4,
                            Genre = Enums.TelevisionGenreCategory.Comedy,
                            GenreTwo = "Documentary",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Nathan.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Planet Earth",
                            Description = "A documentary series on the wildlife found on Earth. Each episode covers a different habitat: deserts, mountains, deep oceans, shallow seas, forests, caves, polar regions, fresh water, plains and jungles. Narrated by David Attenborough.",
                            Stars = "Sigourney Weaver, David Attenborough, Nikolay Drozdov",
                            UserRating = 83,
                            YearStart = 2006,
                            Seasons = 1,
                            Genre = Enums.TelevisionGenreCategory.Documentary,
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/PlanetEarth.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Better Call Saul",
                            Description = "The trials and tribulations of criminal lawyer Jimmy McGill in the years leading up to his fateful run-in with Walter White and Jesse Pinkman.",
                            Stars = "Bob Odenkirk, Rhea Seehorn, Johnathan Banks",
                            UserRating = 95,
                            YearStart = 2015,
                            YearEnd = 2022,
                            Seasons = 6,
                            Genre = Enums.TelevisionGenreCategory.Crime,
                            GenreTwo = "Drama",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Saul.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "The Sopranos",
                            Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                            Stars = "James Gandolfini, Lorraine Bracco, Edie Falco",
                            UserRating = 100,
                            YearStart = 1999,
                            YearEnd = 2007,
                            Seasons = 6,
                            Genre = Enums.TelevisionGenreCategory.Crime,
                            GenreTwo = "Drama",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Sopranos.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Succession",
                            Description = "The Roy family is known for controlling the biggest media and entertainment company in the world. However, their world changes when their father steps down from the company",
                            Stars = "Nicholas Braun, Brian Cox, Kieran Culkin",
                            UserRating = 90,
                            YearStart = 2018,
                            YearEnd = 2023,
                            Seasons = 4,
                            Genre = Enums.TelevisionGenreCategory.Drama,
                            GenreTwo = "Comedy",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Succession.jpg",

                        },

                        new TelevisionModel()
                        {

                            Title = "Twin Peaks",
                            Description = "An idiosyncratic FBI agent investigates the murder of a young woman in the even more idiosyncratic town of Twin Peaks.",
                            Stars = "Kyle MacLachlan, Michael Ontkean, Madchen Amick",
                            UserRating = 97,
                            YearStart = 1990,
                            YearEnd = 1991,
                            Seasons = 2,
                            Genre = Enums.TelevisionGenreCategory.Crime,
                            GenreTwo = "Drama",
                            GenreTwo = "Mystery",
                            Image = "https://raw.githubusercontent.com/GiorgioMotorola/MediaLibrarian/master/MediaLibrarian/Images/TVShowPosters/Twin%20Peaks.jpg",

                        },

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
