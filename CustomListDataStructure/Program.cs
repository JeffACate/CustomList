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

            List<string> myList1 = new List<string>();
            List<string> myList2 = new List<string>();
            List<string> listToSubtract = new List<string>();
            List<string> newList = new List<string>();

            string firstWord = "word1";
            string secondWord = "word3";
            string thirdWord = "word5";
            myList1.Add(firstWord);
            myList1.Add(secondWord);
            myList1.Add(thirdWord);

            firstWord = "word2";
            secondWord = "word4";
            thirdWord = "word6";
            myList2.Add(firstWord);
            myList2.Add(secondWord);
            myList2.Add(thirdWord);

            listToSubtract.Add("word1");
            listToSubtract.Add("word6");

            foreach (string word in myList2)
            {
                myList2.Remove(word);
            }
            foreach (string letter in myList2)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
