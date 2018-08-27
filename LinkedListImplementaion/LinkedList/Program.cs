using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(2, false);
            myList1.Add(7, false);
            myList1.printAllNodes();

            Console.ReadLine();
        }
    } 
}
