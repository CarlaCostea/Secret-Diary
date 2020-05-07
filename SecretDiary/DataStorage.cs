using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecretDiary
{
    public class DataStorage
    {
        private List<RegisterEvent> events;

        public DataStorage()
        {
            events = new List<RegisterEvent>();
        }

        public void AddEvent(RegisterEvent newEvent)
        {
            events.Add(newEvent);
        }
    }
}
