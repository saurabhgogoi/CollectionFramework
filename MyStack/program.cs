using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNonGenericClasses
{
    internal class MyStack
    {
        static void Main()
        {
            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push("Employee");
            stack1.Push(100);
            stack1.Push("Saurabh");
            foreach (Object obj in stack1)
            {
                Console.WriteLine("different types of data" + ":" + obj);
            }
            stack1.Pop();
            foreach (Object obj in stack1)
            {
                Console.WriteLine("after pop operation" + ":" + obj);
            }

            Console.ReadLine();
        }
    }
}
