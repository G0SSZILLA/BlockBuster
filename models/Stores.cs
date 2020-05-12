using System.Collections.Generic;
using BlockBuster.Models;

namespace BlockBuster.models
{
    public class store
    {
        public List<Movie> Movies { get; private set; }

        public List<Movie> RentedMovies { get; private set; }

        public string Title { get; set; }
        public Store(string title)
        {
            Title = title;
            Movies = new List<Movie>();

        }

        public void Setup()
        {
            System.Console.WriteLine($"Welcome to {Title}!");
            Movie lotr = new Movie("Lord of the Rings");
            Movie donnieDarko = new Movie("Donnie Darko");
            Movies.Add(lotr);
            Movies.Add(donnieDarko);

        }

        internal void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie movie = Movies[i];
                System.Console.WriteLine($"{i + 1} - {movie.Title}");
            }
        }

        internal void RentMovie()
        {
            System.Console.WriteLine("Which movie?");
            string input = Console.ReadLine();
            int index;
            if (int.TryParse(input, out index))
            {
                Movie movie = Movies[index - 1];

                if (!movie.Available)
                {
                    System.Console.WriteLine("That movie has already been rented!");

                }
                else
                {
                    movie.Available = false;
                    System.Console.WriteLine($"You Rented {movie.Title}.");
                }

                System.Console.WriteLine(movie.Title);


            }
        }

    }
}