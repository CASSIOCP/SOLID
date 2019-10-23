using System;

namespace Solid.Single_Responsibility
{
    public class Appointment
    {
        public DateTime Date;
        public TimeSpan Duration;
        public string Place;
        public string Description;

        public Appointment(DateTime date, TimeSpan duration, string place, string description)
        {
            Date = date;
            Duration = duration;
            Place = place;
            Description = description;
        }
    }
}