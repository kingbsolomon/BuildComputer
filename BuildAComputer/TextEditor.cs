using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    public class TextEditor: Applications
    {
        public TextEditor(string applicationName, string applicationType, double requiredRAM,
            double requiredStorage)
            :base(applicationName, applicationType, requiredRAM, requiredStorage)
        {
           
        }
    }
}
