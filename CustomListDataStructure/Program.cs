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
            CustomList<string> myList1 = new CustomList<string>();
            string firstWord = "word1";
            string secondWord = "word3";
            string thirdWord = "word5";
            myList1.Add(firstWord);
            myList1.Add(secondWord);
            myList1.Add(thirdWord);


            CustomList<string> myList2 = new CustomList<string>();
            firstWord = "word2";
            secondWord = "word4";
            thirdWord = "word6";
            myList2.Add(firstWord);
            myList2.Add(secondWord);
            myList2.Add(thirdWord);

            CustomList<string> listToSubtract = new CustomList<string>();
            listToSubtract.Add("word1");
            listToSubtract.Add("word16");
            listToSubtract.Add("word6");

            CustomList<string> newList = new CustomList<string>();

            int expected = 4;
            int actual;
            newList = myList1 + myList2;

            //ACT
            newList = newList - listToSubtract;
            Console.ReadKey();

        }
    }
}
