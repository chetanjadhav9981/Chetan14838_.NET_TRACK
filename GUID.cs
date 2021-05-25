using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUIDApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Guid obj = Guid.NewGuid();
            Console.WriteLine("New Guid is " + obj.ToString());
            Console.ReadLine();
            return -1;
        }
    }
}
