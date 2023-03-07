using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.AddElement(10);
            myList.AddElement(30);
            myList.AddElement(40);
            myList.AddElement(50);
            myList.AddElement(60);
            myList.AddElement(70);


            Console.WriteLine(myList[2]);
            Console.WriteLine(myList.NumberOfElements);
            Console.ReadLine();
        }
    }
}
