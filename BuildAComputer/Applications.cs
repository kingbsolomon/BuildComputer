using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class Applications
    {
        //member variables
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        //constructor
        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging Service";
            requiredRAM = 4.0; //In Gigabytes
            requiredStorage = 0.512; //In Gigabytes
        }

    }
}
