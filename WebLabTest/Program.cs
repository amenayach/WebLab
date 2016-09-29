using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLabTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var bundleTester = new BundleTester();

            var projectTemplateTester = new ProjectTemplateTester();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"Hit any key to end the program");
            Console.ReadKey();
        }
    }
}
