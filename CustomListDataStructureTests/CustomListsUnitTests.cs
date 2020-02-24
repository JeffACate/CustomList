﻿using System;
using CustomListDataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListDataStructureTests
{
    [TestClass]
    public class CustomeListUnitTests
    {
        [TestMethod]
        public void Add_CountIncrement()
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
            int actual = myList[3];
            
            //ACT
            myList.Add(15);
            myList.Add(14);
            myList.Add(13);
            myList.Add(numberToCount);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ValuesInListRemain()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int actual = myList[0];

            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_DoubleCapacity()
        {
            CustomList<int> myList = new CustomList<int>();
            int initialCapacity = myList.Capacity;
            int expected = initialCapacity * 2;
            int actual = myList.Capacity;
            
            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);
            // CAPACITY SHOULD DOUBLE
            myList.Add(14);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ItemAddedWhenCapacityIncreased()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 14;
            int actual;

            //ACT
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);

            // CAPACITY SHOULD DOUBLE
            myList.Add(14);
            actual = myList[4];

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
    }
}
