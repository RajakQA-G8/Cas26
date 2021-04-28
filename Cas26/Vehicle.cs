using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Vehicle
    {
        public string Type { get; set; }
        public double MaxSpeed { get; set; }

        public Vehicle()
        {
            this.MaxSpeed = 0;
        }

        public void Move()
        {
            Console.WriteLine("Move!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!");
        }

        protected void Start()
        {
            Console.WriteLine("Start");
        }

    }
}
