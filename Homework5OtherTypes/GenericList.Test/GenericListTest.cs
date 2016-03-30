using System.Runtime.InteropServices;
using System.Text;

namespace GenericList.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Problem3GenericList;

    [TestClass]
    public class GenericListTest
    {
        private GenericList<int> testCollection;

       [TestInitialize]
        public void TestInitialize()
        {
            testCollection = new GenericList<int>();
        }

        [TestMethod]
        public void Test_Add_ShouldAddedCorrect()
        {
            this.testCollection.Add(1);

            int result = testCollection[0];
            int expect = 1;

            Assert.AreEqual(expect, result);

            int length = testCollection.Length;

            Assert.AreEqual(1, length);
        }

        [TestMethod]
        public void Test_Remove_ShouldRemoveItemByIndex()
        {
            testCollection.Add(2);
            Assert.AreEqual(2, testCollection[0]);
            Assert.AreEqual(1, testCollection.Length);

            testCollection.Remove(0);
            Assert.AreEqual(0, testCollection.Length);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Test_Remove_WhenIndexIsInvalidThrowException()
        {
            testCollection.Remove(0);
        }

        [TestMethod]
        public void Test_Indexator_ShouldGetItemInThisIndexOrSet()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            int result = testCollection[0];
            Assert.AreEqual(2, result);
            Assert.AreEqual(2, testCollection.Length);

            testCollection[2] = 8;
            Assert.AreEqual(8, testCollection[2]);
            Assert.AreEqual(3, testCollection.Length);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Test_Indexator_ShouldTrowExceptionIfIndexIsOutOfRange()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            int result = testCollection[2];
        }


        [TestMethod]
        public void Test_Insert_ShouldInsertItemByIndex()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            testCollection.Insert(0, 1);

            Assert.AreEqual(1, testCollection[0]);
            Assert.AreEqual(3, testCollection.Length);
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void Test_Insert_ShouldTrowExceptionToInvalidIndex()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            testCollection.Insert(2, 1);
            testCollection.Insert(-1, 1);
        }

        [TestMethod]
        public void Test_Clear_ShouldClearCoolection()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            testCollection.Clear();
            Assert.AreEqual(0, testCollection.Length);
        }

        [TestMethod]
        public void Test_IndexOf_ShouldReturnIndexOfItemIfNasNotThisItemReturnNegativeDigit()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            int negativeIndex = testCollection.IndexOf(0);
            int correctIndex = testCollection.IndexOf(2);

            Assert.AreEqual(-1, negativeIndex);
            Assert.AreEqual(0, correctIndex);
        }

        [TestMethod]
        public void Test_Min_ShouldReturnMinItem()
        {
            this.testCollection[0] = 1;
            this.testCollection[1] = 112;
            this.testCollection[2] = 9;
            this.testCollection[3] = 17687;

            Assert.AreEqual(1, testCollection.Min());
        }


        [TestMethod]
        public void Test_Max_ShouldReturnMaxItem()
        {
            this.testCollection[0] = 8;
            this.testCollection[1] = 10;
            this.testCollection[2] = 0;
            this.testCollection[3] = 2;

            Assert.AreEqual(10, testCollection.Max());
        }


        [TestMethod]
        public void Test_Contains_ShouldReturnIsContainsThisItem()
        {
            testCollection.Add(2);
            testCollection.Add(3);

            bool resultTrue = testCollection.Contains(2);
            bool resultFalse = testCollection.Contains(8);

            Assert.AreEqual(true, resultTrue);
            Assert.AreEqual(false, resultFalse);
        }

        public void Test_Reverse_ShouldReturnReverseArray()
        {
            testCollection.Add(2);
            testCollection.Add(3);
            testCollection.Add(4);

            Assert.AreEqual(4, testCollection[0]);          
            Assert.AreEqual(3, testCollection[1]);          
            Assert.AreEqual(2, testCollection[2]);          
        }
    }
}