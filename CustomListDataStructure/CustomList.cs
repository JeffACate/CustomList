using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListDataStructure 
{
   public class CustomList<T> : IEnumerable
    {
        private int capacity;
        private int count;
        private T[] items;

        // CONSTRUCTOR
        public CustomList()
        {
            capacity = 4;
            items = new T[4];
            count = 0;
        }
        // PROPERTIES
        public int Count { get => count; }
        public int Capacity { get => capacity; }
        // METHODS
        public void Add(T item)
        {
            if (count == capacity) { IncreaseCapacity(); }
            items[count] = item;
            count++;
        }
        private void IncreaseCapacity()
        {
            int newCapacity = capacity * 2;
            T[] temperaryItems = TransferItems(items, newCapacity); // TO A NEW LIST TEMPERARILY
            items = TransferItems(temperaryItems, newCapacity);
            capacity = newCapacity;
        }
        private T[] TransferItems(T[] fromArray, int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < capacity ; i++) { newArray[i] = fromArray[i]; }
            return newArray;
        }
        public bool Remove(T removedItem)
        {
            // IF ITEM NOT IN LIST SKIP
            bool itemInList = Contains(removedItem);
            if (!itemInList)
            {
                return false;
            }
            // IF ITEM IN LIST 
            int indexToAdd = 0;
            T[] newArray = new T[count];
            bool itemWasRemoved = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(removedItem) && itemWasRemoved.Equals(false))
                {
                    itemWasRemoved = true;
                }
                else
                {
                    newArray[indexToAdd] = items[i];
                    indexToAdd++;
                }
            }


            count--;
            items = newArray;
            return itemWasRemoved;
        }
        public bool Contains(T itemToCheck)
        {
            foreach (T item in items)
            {
                if (itemToCheck.Equals(item)) { return true; }
            }
            return false;
        }
        public override string ToString()
        {
            string sentence = "";
            for (int i = 0; i < count; i++)
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
        public static CustomList<T> operator + (CustomList<T> firstList, CustomList<T> secondList)
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
        public static CustomList<T> operator - (CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.Remove(secondList[i]);
            }
            return firstList;
        }
        public CustomList<T> Zip(CustomList<T> secondList)
        {
            CustomList<T> newList = new CustomList<T>();
            int longestListLenght = Math.Max(count, secondList.Count);

            for (int i = 0; i < longestListLenght; i++)
            {
                if (i < count) { newList.Add(items[i]); }
                if (i < secondList.Count) { newList.Add(secondList[i]); }
            }
            return newList;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++) { yield return items[i]; }
        }
        public T this[int i]
        {
            get 
            {
                if (i > count) { throw new ArgumentOutOfRangeException(); }
                else { return items[i]; }
            }
            set { items[i] = value; }
        }
        public void Sort(T[] array) { }
    }
}
