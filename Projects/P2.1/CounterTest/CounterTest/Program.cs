using System;

namespace Counter
{
    class Program
    {

        private static void PrintCounters(CounterClass[] counter)
        {

            foreach (CounterClass c in counter)
            {
                Console.WriteLine("Counter name is {0}, counter value is {1}", c.Name, c.Value);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            Counter.CounterClass[] myCounter = new CounterClass[3];
            myCounter[0] = new CounterClass("Counter 1");
            myCounter[1] = new CounterClass("Counter 2");
            myCounter[2] = myCounter[0];

            for (int i = 0; i < 4; i++)
            {
                myCounter[0].Increment();
            }

            for (int i = 0; i < 9; i++)
            {
                myCounter[1].Increment();
            }

            PrintCounters(myCounter);
            myCounter[2].Reset();
            PrintCounters(myCounter);
        }
    }
}