using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /* Console.WriteLine("\u0056\u00E4\u0072\u006D\u0064\u00F6\u0020\u0047\u0079\u006D\u006E\u0061\u0073\u0069\u0075\u006D");
             Console.ReadLine();

            //Övning2
            Console.Write("\"hello world\"");
            Console.Read();

            //Övning3a
            string x = "hello world";
            string a = x.ToUpper();

            Console.WriteLine(a);
            Console.Read();

            //övning3b
            string x = "Hello World";
            string a = x.ToLower();

            Console.WriteLine(a);
            Console.Read(); 

            //övning4
            string x = "Hello World";
            
            Console.WriteLine("hello world innehåller " + x.Length + " tecken!");
            Console.Read(); */

            //Övning5
            Console.WriteLine("mata in en text");
            string a = Console.ReadLine();
            


            for (int i = 5; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            


        }
    }
}
