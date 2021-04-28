using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Human
    {
        public string bojaKose { get; set; }
        public string bojaOciju { get; set; }
        public string ime { get; set; }
        public int godine { get; set; }

        public Human()
        {

        }

        public Human(string bojaOciju, string bojaKose, string ime)
        {
            this.bojaKose = bojaKose;
            this.bojaOciju = bojaOciju;
            this.ime = ime;
        }

        public Human(int godine)
        {
            this.godine = godine;
        }

    }
}
