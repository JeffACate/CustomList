using System;
using CustomListDataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListDataStructureTests
{
    [TestClass]
    public class CustomeListUnitTests
    {
        /*
         *  TESTS FOR ~ ADD ~ METHOD
         */

        [TestMethod]
        public void Add_CountIncremented()
        {
            //ARRANGE
            CustomList<string> myList = new CustomList<string>();
            string wordToAdd = "Hello World";
            int expected = 1;

            //ACT
            myList.Add(wordToAdd);
            int actual = myList.Count;
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ValueInput()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int numberToCount = 15;
            int expected = 15;

            //ACT
            myList.Add(numberToCount);
            int actual = myList[0];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ValueAddedToEndOfList()
        {
            CustomList<int> myList = new CustomList<int>();
            int numberToCount = 10;
            int expected = 10;
            int actual;
            
            //ACT
            myList.Add(15);
            myList.Add(14);
            myList.Add(13);
            myList.Add(numberToCount);
            actual = myList[3];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ValuesInListRemain()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int actual;

            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);
            actual = myList[0];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_DoubleCapacity()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = myList.Capacity * 2;
            int actual;
            
            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);

            // CAPACITY SHOULD DOUBLE
            myList.Add(14);
            actual = myList.Capacity;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ItemAddedWhenCapacityIncreased()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 15;
            int actual;

            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);

            // CAPACITY SHOULD DOUBLE
            myList.Add(14);
            myList.Add(15);
            actual = myList[5];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ItemsCopiedWhenCapacityIncreased()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 11;
            int actual;

            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);

            // CAPACITY SHOULD DOUBLE
            myList.Add(14);
            actual = myList[1];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        /*
         *  TESTS FOR ~ REMOVE ~ METHOD
         */

        [TestMethod]
        public void Remove_ItemRemoved_CountDecremented()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            int expected = myList.Count - 1;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList.Count;
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemRemoved()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            bool expected = false;
            bool actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList.Contains(secondNumber);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemBeforeRemains()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            int expected = firstNumber;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList[0];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemAfterRemains()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            int expected = thirdNumber;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList[1];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_OrderRestructured_IndexAfterEqualsIndexRemoved()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            int expected = thirdNumber;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList[1];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemOnlyRemovedOnce_CountDecramentedOnlyOnce()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            int forthNumber = 12;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            myList.Add(forthNumber);

            int expected = 3;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemOnlyRemovedOnce_SecondInstancePersists()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            int forthNumber = 12;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            myList.Add(forthNumber);

            int expected = forthNumber;
            int actual;

            //ACT
            myList.Remove(secondNumber);
            actual = myList[2];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_BoolReturned_True()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            int forthNumber = 12;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            myList.Add(forthNumber);

            bool expected = true;
            bool actual;

            //ACT
            actual = myList.Remove(secondNumber);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_BoolReturned_False()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            int forthNumber = 12;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            myList.Add(forthNumber);

            bool expected = false;
            bool actual;

            //ACT
            actual = myList.Remove(15);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemNotRemoved_CountRemains()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            int forthNumber = 12;

            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);
            myList.Add(forthNumber);

            int expected = 4;
            int actual;

            //ACT
            myList.Remove(15);
            actual = myList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        /*
         *  TESTS FOR ~ TOSTRING ~ METHOD
         */

        [TestMethod]
        public void ToString_IntReturnsString()
        {
            //ASSERT
            CustomList<int> myList = new CustomList<int>();
            int firstNumber = 11;
            int secondNumber = 12;
            int thirdNumber = 13;
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            string expected = "11 12 13";
            string actual;

            //ACT
            actual = myList.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_StringReturnsString()
        {
            //ASSERT
            CustomList<string> myList = new CustomList<string>();
            string firstWord = "Hello";
            string secondWord = "World,";
            string thirdWord = "Jeff!";
            myList.Add(firstWord);
            myList.Add(secondWord);
            myList.Add(thirdWord);

            string expected = "Hello World, Jeff!";
            string actual;

            //ACT
            actual = myList.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_DoubleReturnsString()
        {
            //ASSERT
            CustomList<double> myList = new CustomList<double>();
            double firstNumber = 11.5;
            double secondNumber = 12.5;
            double thirdNumber = 13.5;
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            string expected = "11.5 12.5 13.5";
            string actual;

            //ACT
            actual = myList.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_DecimalReturnsString()
        {
            //ASSERT
            CustomList<decimal> myList = new CustomList<decimal>();
            decimal firstNumber = 0.123m;
            decimal secondNumber = 0.456m;
            decimal thirdNumber = 0.789m;
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            string expected = "0.123 0.456 0.789";
            string actual;

            //ACT
            actual = myList.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_FloatReturnsString()
        {
            //ASSERT
            CustomList<float> myList = new CustomList<float>();
            float firstNumber = 11.123f;
            float secondNumber = 12.456f;
            float thirdNumber = 13.789f;
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            string expected = "11.123 12.456 13.789";
            string actual;

            //ACT
            actual = myList.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
