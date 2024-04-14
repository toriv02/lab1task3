using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]//1-й тест текст только с суммой
        public void positivetext()
        {
            String input = "10+20+30+40";
            Double anser = Logic.findsum(input);
            Assert.AreEqual(100,anser) ;
        }
        [TestMethod()]//2-й тест текст только с разностью
        public void negativetext()
        {
            String input = "0-10-20-30-40";
            Double anser = Logic.findsum(input);
            Assert.AreEqual(-100, anser);
        }
        [TestMethod()]//3-й тест текст с суммой и разностью
        public void midletext()
        {
            String input = "67+84-78-34+54";
            Double anser = Logic.findsum(input);
            Assert.AreEqual(93, anser);
        }
        [TestMethod()]//4-й тест текст только с 1 числом
        public void onenumtext()
        {
            String input = "10";
            Double anser = Logic.findsum(input);
            Assert.AreEqual(10, anser);
        }
        [TestMethod()]//5-й тест текст только с вещественным числом
        public void midletextwihtfructers()
        {
            String input = "10+67-645,4+1000-54,97";
            Double anser = Logic.findsum(input);
            Assert.AreEqual(376,63 , anser);
        }
    }
}