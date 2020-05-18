using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecretDiary
{
    public class DataStorage
    {
        private List<Event> events;

        public DataStorage()
        {
            events = new List<Event>();
        }

        public int Count { get; private set; }

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
            Count++;
        }

        public List<Event> SearchEventByDay(DateTime date)
        {
            List<Event> allDayEvents = new List<Event>();
            foreach (Event @event in events)
            {
                if (@event.TimeStamp.Date == date.Date)
                {
                    allDayEvents.Add(@event);
                }
            }

            return allDayEvents;
        }

        public List<Event> SearchEventByTitle(string title)
        {
            List<Event> commonEvents = new List<Event>();
            foreach (Event @event in events)
            {
                if (@event.Title == title)
                {
                    commonEvents.Add(@event);
                }
            }

            return commonEvents;
        }

        public void DeleteEntriesByDate(DateTime date)
        {
            foreach (Event @event in SearchEventByDay(date))
            {
                events.Remove(@event);
                Count--;
            }
        }

        public void DeleteEntriesByTitle(string title)
        {
            foreach (Event @event in SearchEventByTitle(title))
            {
                events.Remove(@event);
                Count--;
            }
        }
    }
}
