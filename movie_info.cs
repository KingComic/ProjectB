using System;
//namespace cinema_app//
namespace project_b
{
    class Program
    {
        public static void Main()
        {
            //if(answer == "1")//
            var movie_data = new Tuple<string, string, string>[]
            {
                Tuple.Create("Pixels", "1 H 46 M", "Science Fiction, Action, Comedy, Animation, Fantasy"),
                Tuple.Create("CHAPIE", "2 H", "Science Fiction, Action, Crime, Thriller"),
                Tuple.Create("Jurassic World", "2 H 4 M", "Science Fiction, Action, Thriller, Fantasy, Adventure"),
                Tuple.Create("Tron: Lengacy", "2 H 7 M", "Science Fiction, Action, Adventure, Fantasy"),
                Tuple.Create("The Maze Runner", "1 H 54 M", "Science Fiction, Action, Thriller, Adventure")
                
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
            

            Console.WriteLine("\n Title: \n" + movie_data[result - 1].Item1 + "\n \n movie length: \n" + movie_data[result - 1].Item2 + "\n \n genre: \n" + movie_data[result - 1].Item3);      
            
        }   
    }
}
