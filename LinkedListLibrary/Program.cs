using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary {
    class Program {
        static void Main(string[] args) {

            IntLinkedlist mList = new IntLinkedlist();
            mList.insert(5);
            mList.insert(100);
            mList.insert(40);
            mList.print();
            Console.WriteLine("\nCalculating Average...\nAverage = " + mList.getAverage());
            Console.WriteLine("\nCalculating Minimum...\nMinimum = " + mList.getMin());
            Console.WriteLine("\nCalculating Maximum...\nMaximum = " + mList.getMax());
            mList.remove(0);
            mList.remove(5);
            mList.remove(2);
            mList.remove(0);
            mList.print();
            Console.ReadKey();

        }
    }
}
