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
    public class CountLinesTests
    {
        [TestMethod()]
        public void CountLinesTest()
        {
            string text = "If you're going to try, go all the way. Otherwise, don't even start.";
            CountLines lines = new CountLines(text);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Count_lineTest()
        {
            string text = "If you're going to try, go all the way. Otherwise, don't even start.";
            CountLines lines = new CountLines(text);
            int count = 1;
            Assert.IsTrue(count == lines.Count_line());
            //Assert.Fail();
        }
    }
}