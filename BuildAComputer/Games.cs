using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    public class Games: Applications
    {
        //Unique Member Variables

        public double requiredEffectiveMemory;

        public Games (string applicationName, string applicationType, double requiredRAM,
            double requiredStorage, double requiredEffectiveMemory)
            :base(applicationName,applicationType,requiredRAM,requiredStorage)
        {
            this.requiredEffectiveMemory = requiredEffectiveMemory;
        }

       
    }
}
