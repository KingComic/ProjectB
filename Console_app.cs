using System;
using System.Collections.Generic;

namespace cinema_app
{
    // movie objects
    public class Movies
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Year { get; set; }
        public Movies(string name, string info, int year)
        {
            Name = name;
            Info = info;
            Year = year;
        }
    }

    class Program
    {

        static void Main()
        {

            Movies Wolverine = new Movies("X-Men Origins: Wolverine", "The early years of James Logan, featuring his rivalry with his brother Victor Creed, his service in the special forces team Weapon X, and his experimentation into the metal-lined mutant Wolverine.", 2009); //test movie
            var movielist = new Movies[] { Wolverine };
            // void GuestWelcome()
            Console.WriteLine("Welcome to Fictorama! \n" +
            "This is Fictoram Interface 0.01\n\n");

            List<string> options = new List<string> { "1", "2", "3" };
            string answer = "";
            while (!options.Contains(answer))
            {

                Console.WriteLine("Please choose what you want to do: \n" +
                "1. See available movies\n" +
                "2. Login\n" +
                "3. Register\n" +
                "4. Search movies\n"
                );
                answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.WriteLine("You picked \"1. See available movies\" \n" +
                       "WORK IN PROGRESS - Please come back later");
                }
                else if (answer == "2")
                {
                    Console.WriteLine("You picked \"2. Login\" \n" +
                       "WORK IN PROGRESS - Please come back later");
                }
                else if (answer == "3")
                {
                    Console.WriteLine("You picked \"3. Register\" \n" +
                       "WORK IN PROGRESS - Please come back later");
                }
                else if (answer == "4")
                {
                    searchbar();
                }
                else
                { Console.WriteLine("Your input was: " + answer + "\nInput not recognised. Please try again\n"); }
            }
            Console.WriteLine("Shutting down ...");
            void searchbar()
            {
                Console.WriteLine("\n\nWhat would you like to search for?: ");
                string search = Console.ReadLine();
                Console.WriteLine(search);
                Console.WriteLine($"Movie name: \n {movielist[0].Name}");
                Console.WriteLine($"Year of origin: \n {movielist[0].Year}");
                Console.WriteLine($"Movie information: \n {movielist[0].Info}");
            }
        }
    }
}