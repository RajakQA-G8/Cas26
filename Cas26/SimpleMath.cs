using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class SimpleMath
    {

        public int Sum(params int[] brojevi)
        {
            int sum = 0;
            foreach (int broj in brojevi)
            {
                sum += broj; // skraceni oblik: sum = sum + broj
            }

            return sum;
        }

        public static double SSum(params int[] brojevi)
        {
            int sum = 0;
            foreach (int broj in brojevi)
            {
                sum += broj; // skraceni oblik: sum = sum + broj
            }

            return sum;
        }

    }
}
