using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(34, "İstanbul");
            Console.WriteLine("");
            dictionary.Add(35, "İzmir");
            Console.WriteLine("");
            dictionary.Add(36, "Kars");
            Console.WriteLine("");
            dictionary.Add(37, "Kayseri");
            Console.WriteLine("");

            // Using with different types pair
            MyDictionary<int, double> dictionary2 = new MyDictionary<int, double>();
            dictionary2.Add(8, 7.5);   //Rounding example
            Console.WriteLine("");

        }
    }
}

