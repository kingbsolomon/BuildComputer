using System;

namespace BuildAComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer dreamMachine = new Computer();
            Games dota = new Games("Dota","Game",2.0,15.0,2.0);
            //dreamMachine.cpu.CheckGameRequirements(dota, dreamMachine.hardDrive, dreamMachine.ram,dreamMachine.gpu);
            dreamMachine.cpu.ProcessGameInstall(dota, dreamMachine.hardDrive, dreamMachine.ram, dreamMachine.gpu);
            Console.WriteLine(dreamMachine.hardDrive.availableStorage);
            
            
        }
    }
}
