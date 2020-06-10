using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    public abstract class Applications
    {
        //member variables
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        //constructor
        public Applications(string applicationName, string applicationType, double requiredRAM,
            double requiredStorage)
        {
            this.applicationName = applicationName;
            this.applicationType = applicationType;
            this.requiredRAM = requiredRAM;
            this.requiredStorage = requiredStorage;
        }

    }
}
