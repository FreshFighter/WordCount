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
    public class CountWordsTests
    {
        [TestMethod()]
        public void CountWordsTest()
        {
            string text = "i love you i i i";
            CountWords words = new CountWords(text);
            Assert.IsTrue(words.text == text);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Count_wordTest()
        {
            string text = "i love you i i i";
            CountWords words = new CountWords(text);
            int count = 6;
            Assert.IsTrue(count == words.Count_word());
            //Assert.Fail();
        }

        [TestMethod()]
        public void Count_word_frequencyTest()
        {
            string text = "i love you i i i";
            CountWords words = new CountWords(text);
            int count = 4;
            Assert.IsTrue(count == words.Count_word_frequency());
            //Assert.Fail();
        }
    }
}