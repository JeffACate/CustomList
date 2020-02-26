﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListDataStructure
{
   public class CustomList<T>
    {
        private int capacity;
        private int count;
        private T[] items;

        public CustomList()
        {
            capacity = 4;
            items = new T[4];
            count = 0;
        }
        public int Count
        {
            get => count;
        }
        public int Capacity
        {
            get => capacity;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                IncreaseCapacity();
            }
            items[count] = item;
            count++;
        }
        public bool Remove(T item)
        {
            bool itemInList = Contains(item);
            if (!itemInList)
            {
                return false;
            }

            int indexToAdd = 0;
            T[] newArray = new T[count];
            bool itemRemoved = false;
            for (int i = 0; i < count; i++)
            {
                //if(!items[i].Equals(item) && itemRemoved == false)
                //{
                //    newArray[indexToAdd] = items[i];
                //    indexToAdd++;
                //}
                /*else*/
                if (items[i].Equals(item) && itemRemoved== false)
                {
                    itemRemoved = true;
                }
                else
                {
                    newArray[indexToAdd] = items[i];
                    indexToAdd++;
                }
            }
            count--;
            items = newArray;
            return itemRemoved;
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item)) 
                { 
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string sentence = "";
            for (int i = 0; 
                i < count; i++)
            {
                if (i > 0)
                {
                    sentence += " " + items[i];
                }
                else if (i == 0)
                {
                    sentence += items[i];
                }
            }
            return sentence;
        }

        public static CustomList<T> operator+ (CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                combinedList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                combinedList.Add(secondList[i]);
            }
            return combinedList;
        }

        public static CustomList<T> operator- (CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.Remove(secondList[i]);
            }
            return firstList;
        }
        private void IncreaseCapacity()
        {
            int newCapacity = capacity * 2;
            T[] temperaryItems;
            temperaryItems = TransferItems(items, newCapacity, capacity); // TO A NEW LIST TEMPERARILY
            items = new T[newCapacity];
            items = TransferItems(temperaryItems, newCapacity, capacity);
            capacity = newCapacity;
        }
        private T[] TransferItems(T[] oldArray, int newCapacity, int length)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i <= length - 1; i++)
            {
                newArray[i] = oldArray[i];
            }
            return newArray;
        }
        public T this[int i]
        {
            get 
            {
                if (i > count - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else { return items[i]; }
            }
            set { items[i] = value; }
        }
    }
}
