using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Program
    {
        static void Main(string[] args)
        {
            //           indeksi  0, 1, 2, 3, 4,  5,  6, 7,  8, 9
            int[] b = new int[] { 1, 2, 3, 4, 19, 22, 1, 88, 1, 27 };

            int rezultat = Suma(b);

            SimpleMath sm = new SimpleMath();

            int rezultat2 = sm.Sum(1, 2, 3);

            Console.WriteLine("Suma unetih brojeva je rezultat  = {0}", rezultat);
            Console.WriteLine("Suma unetih brojeva je rezultat2 = {0}", rezultat2);
            Console.WriteLine("Suma unetih brojeva je static = {0}", SimpleMath.SSum(1, 2, 3, 4));

            string input = Input.GetUserInput("Upisite broj");

            Human H = new Human("zelena", "crna", "Ana");
            H.godine = 20;
            Console.WriteLine("Godine {0}", H.godine);

            Car zastava = new Car();
            Console.WriteLine(zastava.Type);

            zastava.Move();
            zastava.Stop();
            zastava.Upali();


            Console.ReadKey();
        }

        static int Suma(int[] brojevi)
        {
            int sum = 0;
            foreach(int broj in brojevi)
            {
                sum += broj; // skraceni oblik: sum = sum + broj
            }

            return sum;
        }
        
        static int Suma2(params int[] brojevi)
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
