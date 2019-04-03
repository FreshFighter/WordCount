using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordCountClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCountClassLibrary.Tests
{
    [TestClass()]
    public class CountCharactersTests
    {
        [TestMethod()]
        public void CountCharactersTest()
        {
               string text = "If you're going to try, go all the way. Otherwise, don't even start.";
            CountCharacters characters = new CountCharacters(text);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Count_characterTest()
        {
            string text = "If you're going to try, go all the way. Otherwise, don't even start.";
            CountCharacters characters = new CountCharacters(text);
            int count = 68;
            Assert.IsTrue(count == characters.Count_character());
            //Assert.Fail();
        }
    }
}