using System;
using System.Collections.Generic;
using System.Text;

namespace SecretDiary
{
    public class RegisterEvent
    {
        public RegisterEvent(DateTime eventTimeStamp, string eventTitle, string eventDetails)
        {
            this.EventTimeStamp = eventTimeStamp;
            this.EventTitle = eventTitle;
            this.EventDetails = eventDetails;
        }

        public DateTime EventTimeStamp { get; set; }

        public string EventTitle { get; set; }

        public string EventDetails { get; set; }

        public string GetEvent()
            {
                return EventTimeStamp + "\n" + EventTitle + "\n" + EventDetails;
            }
        }
}
