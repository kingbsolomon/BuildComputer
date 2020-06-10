using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace BuildAComputer
{
    class HardDrive
    {
        //member variables
        public double totalStorage;
        public double availableStorage;
        public List<Applications> applicationsInHardDrive;

        //constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
            //applicationsInHardDrive = new List<Applications>();
        }
    }
}
