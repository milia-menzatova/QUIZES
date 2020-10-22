using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System;

namespace QUIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratings = new List<int>();
            var movie1 = new Movie(1, "Jurassic Park", "Steven Spielger", 1993, ratings);
            movie1.AddRating(5);
            movie1.AddRating(1);
            movie1.AddRating(1);

            movie1.PrintDetails();

        }
    }
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public long ID { get; set; }
        public List<int> Ratings { get; set; }


        public Movie(long movieId, string movieName,
                     string movieDirector, int movieYear,
                     List<int> movieRatings)
        {
            this.ID = movieId;
            this.Title = movieName;
            this.Director = movieDirector;
            this.Year = movieYear;
            this.Ratings = movieRatings;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Movie Id: {this.ID}");
            Console.WriteLine($"Movie Title: {this.Title}");
            Console.WriteLine($"Director: {this.Director}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine("Ratings: ");
            for (int i = 0; i < this.Ratings.Count; i++)
            {
                Console.WriteLine($"{this.Ratings[i]}");
            }
            Console.WriteLine($"Average: {this.GetAverageRating()}");
        }

        public void AddRating(int newRating)
        {
            if (newRating >= 1 && newRating <= 5)
            {
                this.Ratings.Add(newRating);
            }
        }

        public double GetAverageRating()
        {
            double sum = 0d;
            int count = this.Ratings.Count;
            for (int i = 0; i < count; i++)
            {
                sum = sum + this.Ratings[i];
            }
            double avg = sum / count;
            return avg;
        }
    }
}
