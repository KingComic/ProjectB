using System;
using System.Collections.Generic;

namespace cinema_app
{
    class Program
    {

        static void Main()
        {
            void WelcomeScreen()
            {

                Console.WriteLine("Welcome to Fictorama! \n" +
                    "This is Fictoram Interface 0.02\n\n");

                List<string> options = new List<string> { "1", "2", "3", "4" };
                string answer = "";
                while (!options.Contains(answer))
                {

                    Console.WriteLine("Please choose what you want to do: \n" +
                    "1. See available movies\n" +
                    "2. Login\n" +
                    "3. Register\n" +
                    "4. Exit program\n"
                    );
                    answer = Console.ReadLine();


                    if (answer == "1")
                    {

                        MovieBrowser();

                    }
                    else if (answer == "2")
                    {

                        LoginScreen();

                    }
                    else if (answer == "3")
                    {

                        RegisterScreen();

                    }
                    else if (answer == "4")
                    {
                        ExitScreen();
                    }
                    else
                    { Console.WriteLine("Your input was: " + answer + "\nInput not recognised. Please try again\n"); }
                }
                Console.WriteLine("Shutting down ...");
            }


            void MovieBrowser()
            {

                List<string> options = new List<string> { "1", "2", "3", "4", "5" };
                string answer = "";
                while (!options.Contains(answer))
                {
                    Console.WriteLine(
                    "\nYou picked \"1. See available movies\" \n\n" +


                    "NOW PLAYING: \n" +

                    "1. Star Wars: The Rise of Skywalker (2019) \n" +
                    "2. Archive (2020)\n" +
                    "3. Underwater  (2020)\n" +
                    "4. The Martian (2015)\n" +
                    "5. Guardians of the Galaxy Vol 2\n"
                    );

                    Console.WriteLine(
                        "Select a movie to learn more about it..."
                        );
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        // Hier misschien een method genaamd StarWarsTheRiseOfTheSkyWalker()
                        // Met daarmee een call naar die film waarin je weer losse info kan zetten

                        Console.WriteLine("1.Star Wars: The Rise of Skywalker(2019) \n" +
                            "No information available yet.");

                    }
                    else if (answer == "2")
                    {

                        Console.WriteLine("2. Archive (2020)\n" +
                            "No information available yet.");

                    }
                    else if (answer == "3")
                    {

                        Console.WriteLine("3. Underwater  (2020)\n" +
                            "No information available yet.");

                    }
                    else if (answer == "4")
                    {
                        Console.WriteLine("4. The Martian (2015)\n" +
                            "No information available yet.");
                    }
                    else if (answer == "5")
                    {
                        Console.WriteLine("5. Guardians of the Galaxy Vol 2\n" +
                            "No information available yet.");
                    }
                    else
                    { Console.WriteLine("Your input was: " + answer + "\nInput not recognised. Please try again\n"); }

                }



            }
            void LoginScreen()
            {
                Console.WriteLine("You picked \"2. Login\" \n" +
                        "WORK IN PROGRESS - Please come back later");
            }

            void RegisterScreen()
            {
                Console.WriteLine("You picked \"3. Register\" \n" +
                    "WORK IN PROGRESS - Please come back later");
            }
            void ExitScreen()
            {
                Console.WriteLine("Shutting down...");
            }

            WelcomeScreen();
        }
    }
}
