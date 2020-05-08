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
        public void Test()
        {
            DataStorage thisWeek = new DataStorage();
            RegisterEvent morning = new RegisterEvent(DateTime.Now , "Coffe", "bIS");
            thisWeek.AddEvent(morning);
            RegisterEvent afternoon = new RegisterEvent(DateTime.Now, "Work", "I'm working on my project");
            thisWeek.AddEvent(afternoon);
            RegisterEvent evening = new RegisterEvent(DateTime.Now, "Work", "I'm still working on my project");
            thisWeek.AddEvent(evening);
            Assert.Equal(thisWeek.ToString(), morning.GetEvent() + afternoon.GetEvent() + evening.GetEvent());
        }
    }
}
