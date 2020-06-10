using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class CPU
    {
        //member variables
        public string manufacturer;
        public string name;

        //constructor
        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }
    }
}
