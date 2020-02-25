﻿using System;
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



        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void Add_OutOfRangeException()
        //{
        //    CustomList<int> customList = new CustomList<int>();
        //    Console.WriteLine(customList[2]);
        //}
    }
}
