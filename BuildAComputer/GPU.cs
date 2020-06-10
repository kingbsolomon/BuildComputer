using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class GPU
    {
        //member variables

        public string manufacturer;
        public double effectiveMemory;

        //constructor
        public GPU(string manufacturer, double effectiveMemory)
        {
            this.manufacturer = manufacturer;
            this.effectiveMemory = effectiveMemory;
        }

       
    }
}
