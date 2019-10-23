using System;
using System.Linq;
using System.Collections.Generic;

namespace Solid.Single_Responsibility
{
    public class Homework : IEntryManager<Task>
    {
        private readonly List<Task> tasks = new List<Task>();

        public void AddEntry(Task entry)
        {
            tasks.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            tasks.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, tasks.Select(x =>
                $"Discipline: {x.Discipline.ToString().PadRight(10, ' ')} " +
                $"Date: {x.Date.ToShortDateString() }  " +
                $"Description: {x.Description}"));
        }
    }
}