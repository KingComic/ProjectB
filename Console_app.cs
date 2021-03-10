using System;
using System.Collections.Generic;

namespace cinema_app
{
    class Program
    {

        static void Main()
        {
        // void GuestWelcome()
        Console.WriteLine("Welcome to Fictorama! \n" +
            "This is Fictoram Interface 0.01\n\n");

        List<string> options = new List<string> { "1","2","3" };
        string answer = "";
        while(!options.Contains(answer)){

            Console.WriteLine("Please choose what you want to do: \n" +
            "1. See available movies\n" +
            "2. Login\n"+
            "3. Register\n"
            );
            answer = Console.ReadLine();


            if(answer == "1")
                {Console.WriteLine("You picked \"1. See available movies\" \n" +
                    "WORK IN PROGRESS - Please come back later");}
            else if(answer == "2")
                {Console.WriteLine("You picked \"2. Login\" \n" +
                    "WORK IN PROGRESS - Please come back later");}
            else if(answer == "3")
                {Console.WriteLine("You picked \"3. Register\" \n" +
                    "WORK IN PROGRESS - Please come back later");}
            else
                {Console.WriteLine("Your input was: " + answer + "\nInput not recognised. Please try again\n");}
            }
        Console.WriteLine("Shutting down ...");
        }
    }
}
