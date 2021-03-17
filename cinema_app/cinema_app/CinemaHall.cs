using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_app
{
    class CinemaHall
    {
        public List<Tuple<string,string>> HallReservation = new List<Tuple<string,string>>() ;

        public void Addreservation()
        {
            Console.WriteLine("Please type the year of the the reservation: ");
            int year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please type the month in numbers of the the reservation: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the day of the the reservation: ");
            int day = Convert.ToInt32(Console.ReadLine());

            var reservationDate = new DateTime(year,month,day);
            var convertdate = reservationDate.Date.ToString("dd-MM-yyyy");

            Console.WriteLine("Please type the name of the movie: ");
            var movieName = Console.ReadLine();

            this.HallReservation.Add(Tuple.Create(convertdate, movieName));
        }

    }
}
