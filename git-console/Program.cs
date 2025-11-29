using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMethod();
            PrintUserId(1);
        }
        static void TestMethod()
        {
            Console.WriteLine("This is a test method.");
        }
        
        static void PrintUserId(int id)
        {
            Console.WriteLine(id);
        }
    }
}
