using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> customList = new CustomList<int>();
            //customList.Add(1);
            //customList.Add(2);
            //customList.Add(45);

            //Console.WriteLine(customList[1] + customList[2]);
            //Console.ReadKey();
            //List<int> numbs = new List<int>() { 0, 1, 2, 3, 4, 5 };
            //numbs.Remove(4);
            //numbs.Remove(3);
            //numbs.Remove(0);
            //numbs.Remove(1);
            //Console.ReadKey();
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

        }
    }
}
