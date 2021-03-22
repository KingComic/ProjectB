using System;
using System.Collections.Generic;

namespace cinema_app
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var avangers = new Movie(3, 20, "Avenger");

            var movies = new List<Movie>() { avangers };

            var zaal1 = new CinemaHall(20, 9);

            zaal1.Addreservation(movies);

            Console.WriteLine();

            Console.WriteLine(zaal1.GetHallSeatsScreen());

            Console.WriteLine();

            zaal1.SetPrice();

            Console.WriteLine();

            zaal1.SeePrice();

        }
    }
}
