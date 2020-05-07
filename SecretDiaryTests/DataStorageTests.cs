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
            RegisterEvent monday = new RegisterEvent(DateTime.Today , "Coffe", "bIS");
            thisWeek.AddEvent(monday);
        }
    }
}
