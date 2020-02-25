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
            get { return count; } 
        }
        public int Capacity
        { 
            get { return capacity; }
        }

        public void Add(T item)
        {
            if (count <= capacity-1)
            {
                items[count] = item;
                count++;
            }
            else
            {
                IncreaseCapacity(item);
            }
        }
        private void IncreaseCapacity(T item)
        {
            T[] temperary = new T[capacity*2];
            for (int i = 0; i <= capacity-1; i++)
            {
                temperary[i] = items[i];
            }
            items = new T[capacity*2];
            for (int i = 0; i <= capacity-1; i++)
            {
                items[i] = temperary[i];
            }
            capacity *= 2;
            items[count] = item;
        }
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

    }
}