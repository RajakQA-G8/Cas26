using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Input
    {
        public static string GetUserInput(string message)
        {
            Console.Write($"{message} >");
            return Console.ReadLine();
        }
    }
}
