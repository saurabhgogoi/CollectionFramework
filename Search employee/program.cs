using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNonGenericClasses
{
    internal class SearchList
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Pavan");
            list.Add("sai kiran");
            list.Add("Pranay");
            list.Add("Kalyan");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.WriteLine("enter person name:");
            string X = Console.ReadLine();
            if (list.Contains(X))
            {
                Console.WriteLine("yes " + X + " is an employee");
            }
            else
            {
                Console.WriteLine("no");
            }



            Console.ReadLine();
        }
    }
}
