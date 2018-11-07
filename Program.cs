using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Factory.StartNew(speak);
            //Task t= Task.Run(new Action(speak));
           // t.Start();
            Console.WriteLine("Waiting for completion");
            t.Wait();
            Console.WriteLine("All Done");

            Console.ReadLine();
        }
        private static void speak()
        {
            Console.WriteLine("Hello World");
            // Console.ReadLine();
        }
    }
}