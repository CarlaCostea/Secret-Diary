using System;
using System.Collections.Generic;
using System.Text;

namespace SecretDiary
{
    public class Event
    {
        public Event(DateTime eventTimeStamp, string eventTitle, string eventDetails)
        {
            this.TimeStamp = eventTimeStamp;
            this.Title = eventTitle;
            this.Story = eventDetails;
        }

        public DateTime TimeStamp { get; set; }

        public string Title { get; set; }

        public string Story { get; set; }

        public string GetEvent()
            {
                return TimeStamp + "\n" + Title + "\n" + Story;
            }
        }
}
