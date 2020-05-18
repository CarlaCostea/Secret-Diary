using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SecretDiary
{
    public class EventTests
    {
        [Fact]
        public void RegisterAnEvent()
        {
            Event myFirstEvent = new Event(DateTime.Now, "New test", "I'm trying to add an event in my Secret Diary");
            string firstEvent = DateTime.Now + "\n" + "New test" + "\n" + "I'm trying to add an event in my Secret Diary";
            Assert.Equal(firstEvent, myFirstEvent.GetEvent());
            Assert.Equal("New test", myFirstEvent.Title);
            Assert.Equal("I'm trying to add an event in my Secret Diary", myFirstEvent.Story);
        }
    }
}
