using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Car : Vehicle
    {
        public Car() : base()
        {
            this.Type = "Car";
            this.MaxSpeed = 100;
        }

        public void Upali()
        {
            this.Start();
        }

        new public void Move()
        {
            Console.WriteLine("MOVE HERE!");
        }
    }
}
