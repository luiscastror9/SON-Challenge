using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SONConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=50; i++)
            {
                
                if((i % 3) == 0)
                {
                    Console.WriteLine("Nursing");
                }
                else if ((i % 7) == 0)
                {
                    Console.WriteLine("Meliora");
                }
                else if (((i % 7) == 0) && ((i % 3) == 0))
                {
                    Console.WriteLine("Nursing Meliora");
                }
                else { Console.WriteLine(i); }
            }
            Console.ReadLine();
        
        }
    }
}
