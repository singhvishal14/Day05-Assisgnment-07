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
            Console.WriteLine("Entered the fruit Name you want to Insert: ");
            string FruitInsert=Console.ReadLine();
            Console.WriteLine("After Inserting: ");
            fruitsList.Insert(1, FruitInsert);
            Console.WriteLine("The Number of Fruits are in fruitsList is: " + fruitsList.Count);
            foreach (string str in fruitsList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Entered the fruit Name you want to Remove: ");
            string FruitRemove=Console.ReadLine();
            Console.WriteLine("After Removing: ");
            fruitsList.Remove(FruitRemove);
            Console.WriteLine("The Number of Fruits are in fruitsList is: " + fruitsList.Count);
            foreach (string str in fruitsList)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();

        }
    }
}
