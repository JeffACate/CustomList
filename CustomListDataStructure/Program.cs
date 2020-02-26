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
            CustomList<double> myList = new CustomList<double>();
            double firstNumber = 11.5;
            double secondNumber = 12.5;
            double thirdNumber = 13.5;
            myList.Add(firstNumber);
            myList.Add(secondNumber);
            myList.Add(thirdNumber);

            Console.WriteLine(myList.ToString());
            Console.ReadKey();
        }
    }
}
