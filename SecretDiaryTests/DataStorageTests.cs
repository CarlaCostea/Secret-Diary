using Microsoft.VisualBasic;
using SecretDiary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SecretDiaryTests
{
    public class DataStorageTests
    {
        [Fact]
        public void TestAddEvent()
        {
            DataStorage thisWeek = new DataStorage();
            Event morning = new Event(DateTime.Now , "Coffe", "bIS");
            thisWeek.AddEvent(morning);
            Event afternoon = new Event(DateTime.Now, "Work", "I'm working on my project");
            thisWeek.AddEvent(afternoon);
            Event evening = new Event(DateTime.Now, "Work", "I'm still working on my project");
            thisWeek.AddEvent(evening);
        }

        [Fact]
        public void CountEvents()
        {
            DataStorage thisWeek = new DataStorage();
            Event morning = new Event(DateTime.Now, "Coffe", "bIS");
            thisWeek.AddEvent(morning);
            Event afternoon = new Event(DateTime.Now, "Work", "I'm working on my project");
            thisWeek.AddEvent(afternoon);
            Event evening = new Event(DateTime.Now, "Work", "I'm still working on my project");
            thisWeek.AddEvent(evening);
            Assert.Equal(3, thisWeek.Count);
        }
    }
}
