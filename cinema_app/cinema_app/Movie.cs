using System;
namespace cinema_app
{
    public class Movie
    {

        public int HoursLength;
        public int MinuteLength;
        public string Name;

        public Movie(int hours,int minutes,string name)
        {
            this.HoursLength = hours;
            this.MinuteLength = minutes;
            this.Name = name;

        }
    }
}
