using System;

namespace cinema_app
{

    
    public partial class cinema_app
        
    {
        
        public void MovieBrowser()

        { 
            var movie_data = new Tuple<string, string, string, string>[]
            {
                Tuple.Create("Pixels", "1 H 46 M", "Science Fiction, Action, Comedy, Animation, Fantasy",
                "Adam Sandler plays Sam Brenner \n Josh gad plays Ludlow Lamonsoff \n Peter Dinklage plays Eddie Plant"),

                Tuple.Create("CHAPIE", "2 H", "Science Fiction, Action, Crime, Thriller",
                "Anri du Toit plays Yolandi \n Watkin Tudor Jones plays Ninja \n Hugh Jackman plays Vincent Moore"),

                Tuple.Create("Jurassic World", "2 H 4 M", "Science Fiction, Action, Thriller, Fantasy, Adventure",
                "Chris Pratt plays Owen Grady \n "),

                Tuple.Create("Tron: Lengacy", "2 H 7 M", "Science Fiction, Action, Adventure, Fantasy",
                "Garrett Hedlund plays Sam Flynn \n Jeff Bridges plays Kevin Flynn"),

                Tuple.Create("The Maze Runner", "1 H 54 M", "Science Fiction, Action, Thriller, Adventure",
                "Dylan O'Brien plays Thomas \n Thomas Brodie-Sangster plays Newt \n Will Poulter plays Gally")

            };

            for (int choices = 0; choices < movie_data.Length; choices++)
            {
                Console.WriteLine($"{choices + 1}. " + movie_data[choices].Item1);
                


            }
            
            Console.WriteLine("\n \nPlease choose a movie to see the information about the movie: ");
            string choice = "";
            choice = Console.ReadLine();
            int result = 0;

            try
            {
                result = Int32.Parse(choice);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{choice}'");
            }

            if (result <= movie_data.Length && result > 0)
            {
                Console.WriteLine("Title: \n" + movie_data[result - 1].Item1);
                Console.WriteLine("\n \nmovie length: \n" + movie_data[result - 1].Item2);
                Console.WriteLine("\n \ngenre: \n" + movie_data[result - 1].Item3);
                Console.WriteLine("\n \ncast: \n " + movie_data[result - 1].Item4);
            }
            
            else
            {
                Console.WriteLine("This number does not exist");
            }
            
            Console.WriteLine("\n\n press enter to go back to the homescreen");
            string next = "";
            next = Console.ReadLine();

            
            
        }
        
    }
}
