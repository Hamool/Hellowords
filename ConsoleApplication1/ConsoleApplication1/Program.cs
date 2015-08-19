using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.Write("What's the fox say? ");
            Console.WriteLine("the fox says: {0} {1} {2}", Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Thy Key Has Been Pressed.");
            for (short i = 0; i <= 10; i++)
            {
                Console.WriteLine("Variable i={0}", i);
            }
        }
    }
}
