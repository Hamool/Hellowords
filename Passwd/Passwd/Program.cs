using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Passwd
{
    class Program
    {
        static void Main()
        {
            Boolean incorrect = true;
            while(incorrect)
            {
                Console.Write("password:" );
                string psswd = Console.ReadLine();
                if (psswd!="asdfg")
                {
                    Console.WriteLine("WRONG!");
                }
                else
                {
                    incorrect = false;
                    Console.WriteLine("Correct!");
                }
            }
        }
    }
}
