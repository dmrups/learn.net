using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockTest
{
    static class Program
    {
        static volatile object lockObject = new object();

        static void Main(string[] args)
        {
            lock (lockObject)
            {
                Console.WriteLine("locked");
            }

            Console.WriteLine("unlocked");
            Console.ReadLine();
        }
    }
}
