using System;
using System.Collections.Generic;
using System.Text;

namespace cinema_app
{
    class CinemaHall
    {

        //Movie related data
        public List<Tuple<Tuple<int, int, int>, Tuple<int, int>, Movie, bool[,]>> HallReservation = new List<Tuple<Tuple<int,int,int>,Tuple<int,int>, Movie, bool[,]>>();

        //Hall related data
        public int Rows;
        public int Colums;
        public double FirstClassPrice;
        public double SecondeClassPrice;
        public double TherdeClassPrice;
        public double[,] Hallprice;


        public CinemaHall(int rows, int colums)
        {
            this.Rows = rows;
            this.Colums = colums;


            this.Hallprice = new double[rows, colums];
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Colums; j++)
                {
                    this.Hallprice[i, j] = 0.16;
                }
            }



        }


        public void Addreservation(List<Movie> movies)
        {
            Console.WriteLine("Please type the year of the the reservation: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the month in numbers of the the reservation: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the day of the the reservation: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the time(hour) for te movie: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the time(minute) for te movie: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please choose the movie: ");
            for (int i = 0; i < movies.Count; i++) {
                Console.WriteLine(i + " " + movies[i].Name);
            }

            int selsction = Convert.ToInt32(Console.ReadLine());


            this.HallReservation.Add(Tuple.Create(Tuple.Create(day,month,year), Tuple.Create(hour,minute),movies[selsction] ,new bool[Rows, Colums]));
        }

        public string GetHallSeatsScreen()
        {

            string hall = "";

            if (this.HallReservation.Count > 0)
            {

                Console.WriteLine("Please choice the movie, to see the seats status: ");
                for (int i = 0; i < this.HallReservation.Count; i++)
                {
                    Console.WriteLine(i + " " + this.HallReservation[i].Item3.Name + " At "
                        + this.HallReservation[i].Item1.Item1 + "-" + this.HallReservation[i].Item1.Item2
                        + "-" + this.HallReservation[i].Item1.Item3 + ", and will begin at " + this.HallReservation[i].Item2.Item1 + ":" +
                        this.HallReservation[i].Item2.Item2 + " hour.");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                int count = 0;


                for (int i = 0; i < this.Rows; i++)
                {
                    for (int j = 0; j < this.Colums; j++)
                    {
                        if (this.HallReservation[choice].Item4[i, j] == false)
                        {
                            hall += "| 0 ";
                            count += 1;
                        }
                        else
                        {
                            hall += "| X ";
                        }
                    }
                    hall += "|\n";

                }

                hall += "\nThere are " + count + " Seats left. \n'0' stands for seats left. \n'X' stands for seats in use.";
                

            }
            else
            {
                hall = "There are now movie reservations";
            }


            return hall;
        }

        public void SetPrice()
        {
            Console.WriteLine("There are " + this.Rows + " rows and " + this.Colums + " colums, Please select the range of colums in a row");

            Console.WriteLine("Which row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Begin at colume: ");
            int beginColume = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And at colume: ");
            int endColume = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the price:");
            double price = Convert.ToDouble(Console.ReadLine());


            for (int i = beginColume; i <= endColume; i++) {
                this.Hallprice[row, i] = price;
            }

        }

        public void SeePrice()
        {
            string hall = "";
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Colums; j++)
                {
                    hall += "| " + this.Hallprice[i, j];

                }
                hall += " |\n";
            }
            Console.WriteLine(hall);
        }
    }
}
