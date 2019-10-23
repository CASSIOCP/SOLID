using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Single_Responsibility
{
    public class Schedule : IEntryManager<Appointment>
    {
        private readonly List<Appointment> appointments = new List<Appointment>();

        public void AddEntry(Appointment entry)
        {
            appointments.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            appointments.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, appointments.Select(x =>
                $"Date: {x.Date.ToShortDateString()} " +
                $"Duration: {x.Duration.ToString() } " +
                $"Palce: {x.Place } " +
                $"Description: {x.Description}"));
        }
    }
}