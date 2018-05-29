using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit_Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_OnNewStack_ReturnsTrue()
        {
            Stack target = new Stack();
            bool expected = true;
            Assert.AreEqual(expected, target.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_OnNewStack_ReturnsFalse()
        {
            Stack target = new Stack();
            bool expected = false;
            target.Push("test");
            Assert.AreEqual(expected, target.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_1ItemStack_ReturnsFalse()
        {
            Stack target = new Stack();
            bool expected = false;
            target.Push("test");
            Assert.AreEqual(expected, target.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_OnStackThatHadItems_ReturnsTrue()
        {
            Stack target = new Stack();
            bool expected = true;
            target.Push("test1");
            String answer = target.Pop();
            Assert.AreEqual(expected, target.IsEmpty());
        }

        [TestMethod]
        public void Peek_SevenItems_NothingDeleted_ReturnsLastAdded()
        {
            Stack target = new Stack();
            target.Push("test1");
            target.Push("test2");
            target.Push("test3");
            target.Push("test4");
            target.Push("test5");
            target.Push("test6");
            target.Push("test7");
            String answer = target.Peek();
            String expected = "test7";
            int expectedNum = 7;
            Assert.AreEqual(expected, answer);
            Assert.AreEqual(expectedNum, target.Count());
        }

        [TestMethod]
        public void Count_3Items_ReturnsTrue()
        {
            Stack target = new Stack();
            target.Push("test1");
            target.Push("test2");
            target.Push("test3");
            int expected = 3;
            Assert.AreEqual(expected, target.Count());
        }

        [TestMethod]
        public void Count_NItems_ReturnsTrue()
        {
            Stack target = new Stack();
            Random ran = new Random();
            int ranNum = ran.Next(1000) + 1;
            for (int i = 0; i < ranNum; i++)
            {
                target.Push("" + i);
            }
            Assert.AreEqual(ranNum, target.Count());
        }

        [TestMethod]
        public void PushPopCount_BigStackSize_ReturnsTrue()
        {
            Stack target = new Stack();
            int Num = 500;
            int removeNum = 100;
            int expected = Num - removeNum;
            for (int i = 0; i < Num; i++)
            {
                target.Push("" + i);
            }

            for (int i = 0; i < removeNum; i++)
            {
                target.Pop();
            }

            Assert.AreEqual(expected, target.Count());
        }

        /*
         * 
        [TestMethod]
        public void IsEmpty_OnNewStack_ReturnsFalse()
        {
        }

        */

        [TestMethod]
        public void Count_OnEmptyStack_ReturnsTrue()
        {
            Stack target = new Stack();
            int expected = 0;
            Assert.AreEqual(expected, target.Count());
        }

        [TestMethod]
        public void Count_OnEmptyStackThatHadItems_ReturnsTrue()
        {
            Stack target = new Stack();
            target.Push("test1");
            target.Push("test2");
            target.Push("test3");
            target.Pop();
            target.Pop();
            target.Pop();
            int expected = 0;
            Assert.AreEqual(expected, target.Count());
        }

        [TestMethod]
        public void Peek_OnStackThatHad1ItemThenPop_ReturnsTrue()
        {
            Stack target = new Stack();
            target.Push("test1");
            target.Push("test2");
            target.Pop();
            String expected = "test1";
            Assert.AreEqual(expected, target.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Peek_OnEmptyStack_ReturnsException()
        {
            Stack target = new Stack();
            String answer = target.Peek();
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Pop_OnEmptyStack_ReturnsException()
        {
            Stack target = new Stack();
            target.Pop();
        }
    }
}
