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

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.applicationsInHardDrive.Add(app);
            hardDrive.availableStorage -= app.requiredStorage;

        }

        public bool CheckReqiurements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if(app.requiredRAM <= ram.totalGigabytes
                && app.requiredStorage <= hardDrive.availableStorage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
