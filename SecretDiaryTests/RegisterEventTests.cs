using SecretDiary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircularDoublyLinkedListTest
{
    public class RegisterEventTests
    {
        [Fact]
        public void RegisterAnEvent()
        {
            RegisterEvent myFirstEvent = new RegisterEvent(DateTime.Now, "New test", "I'm trying to add an event in my Secret Diary");
            string firstEvent = DateTime.Now + "\n" + "New test" + "\n" + "I'm trying to add an event in my Secret Diary";
            Assert.Equal(firstEvent, myFirstEvent.GetEvent());
        }
    }
}
