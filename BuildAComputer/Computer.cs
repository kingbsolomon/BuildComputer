using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAComputer
{
    class Computer
    {
        public RAM ram;
        public CPU cpu;
        public GPU gpu;
        public HardDrive hardDrive;
        public Motherboard motherboard;

        //constructor
        public Computer()
        {
           ram = new RAM(60,"CORSAIR");
           cpu = new CPU("AMD","Ryzen 9");
           gpu = new GPU("NVIDIA",8.0);
           hardDrive = new HardDrive(2000.00, 1985.00);
           motherboard = new Motherboard("ASUS", cpu, ram, hardDrive, gpu);

        }
    }
}
