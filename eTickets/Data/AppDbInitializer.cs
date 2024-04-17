using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();


                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema() {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the firsst cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the firsst cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the firsst cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the firsst cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the fisst cinema"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        new Actor() {
                            FullName = "Actor 1",
                            Bio = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Actor() {
                            FullName = "Actor 2",
                            Bio = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Actor() {
                            FullName = "Actor 3",
                            Bio = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Actor() {
                            FullName = "Actor 4",
                            Bio = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Actor() {
                            FullName = "Actor 5",
                            Bio = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Producer.Any())
                {
                    context.Producer.AddRange(new List<Producer>()
                    {
                        new Producer() {
                            FullName = "Producer 1",
                            Bio = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Producer() {
                            FullName = "Producer 2",
                            Bio = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Producer() {
                            FullName = "Producer 3",
                            Bio = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Producer() {
                            FullName = "Producer 4",
                            Bio = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        },
                        new Producer() {
                            FullName = "Producer 5",
                            Bio = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            ProfilePictureURL = "This is the description of the firsst cinema"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                        new Movie() {
                            Name = "Scoob",
                            Description = "No description",
                            Price = 10,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie() {
                            Name = "Prova",
                            Description = "No description",
                            Price = 10,
                            ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie() {
                            Name = "Prova1",
                            Description = "No description",
                            Price = 10,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie() {
                            Name = "Prova2",
                            Description = "No description",
                            Price = 10,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 3,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie() {
                            Name = "Prova3",
                            Description = "No description",
                            Price = 10,
                            ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Comedy
                        }

                    });
                    context.SaveChanges();
                }
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie() {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie() {
                            ActorId = 5,
                            MovieId = 1
                        },
                        new Actor_Movie() {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie() {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new Actor_Movie() {
                            ActorId = 2,
                            MovieId = 2
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
