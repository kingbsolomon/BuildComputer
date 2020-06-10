using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class Motherboard
    {
        //member variables
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        //Constructor
        public Motherboard(string manufacturer, CPU processor, 
                RAM temporaryMemory, HardDrive storage, GPU graphics)
        {
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.temporaryMemory = temporaryMemory;
            this.storage = storage;
            this.graphics = graphics;
        }

        /*public void InstallApplication(Applications application)
        {
            if(application.requiredRAM <= temporaryMemory.totalGigabytes 
                && application.requiredStorage <= storage.availableStorage)
            {
                storage.applicationsInHardDrive.Add(application);
            }
            
        }*/

    }
}
