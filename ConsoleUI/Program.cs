using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmClock;
using YieldFibonacci;
using BinarySearch;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm a1 = new Alarm();
            a1.AlarmClock += SetAlarm;
            //a1.SimulateAlarm(5, "hello");

            foreach (int item in Fibonacci.GetSequence(5))
            {
                Console.WriteLine(item);
            }

            string[] arr = { "a", "b", "d", "o" };
            Console.WriteLine(arr.BinSearsh<string>("b", null));
            Console.Read();
        }

        static void SetAlarm(Object sender, AlarmEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Message);
        }
    }
}
