using System;

namespace cinema_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var zaal1 = new CinemaHall();


            zaal1.Addreservation();

            foreach (var lis in zaal1.HallReservation) 
            {
                
                Console.WriteLine(lis);
                
            }

        }
    }
}
