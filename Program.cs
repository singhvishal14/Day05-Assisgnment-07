using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY05_Assishnment_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruitsList = new ArrayList();
            fruitsList.Add("apple");
            fruitsList.Add("banana");
            fruitsList.Add("cherry");
            fruitsList.Add("Date");
            fruitsList.Add("elderberry");
            Console.WriteLine("The Number of Fruits are in fruitsList is: "+fruitsList.Count);
            if (fruitsList.Contains("Date"))
            {
                Console.WriteLine("Date is Present in the list");
            }
            else
            {
                    Console.WriteLine("Not Contain");
            }
            Console.WriteLine("After Inserting: ");
            fruitsList.Insert(1, "fig");
            Console.WriteLine("The Number of Fruits are in fruitsList is: " + fruitsList.Count);
            foreach (string str in fruitsList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("After Removing: ");
            fruitsList.Remove("banana");
            Console.WriteLine("The Number of Fruits are in fruitsList is: " + fruitsList.Count);
            foreach (string str in fruitsList)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();

        }
    }
}
