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

        public void ProcessAppInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool check = CheckAppRequirements(app, hardDrive, ram);

            if (check)
            {
                hardDrive.applicationsInHardDrive.Add(app);
                hardDrive.availableStorage -= app.requiredStorage;
            }
        }

        public void ProcessGameInstall(Games game, HardDrive hardDrive, RAM ram,
            GPU gpu)
        {
            bool check = CheckGameRequirements(game, hardDrive, ram, gpu);
            if (check)
            {
                hardDrive.applicationsInHardDrive.Add(game);
                hardDrive.availableStorage -= game.requiredStorage;
            }
        }



        public bool CheckAppRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (app.requiredRAM <= ram.totalGigabytes
                && app.requiredStorage <= hardDrive.availableStorage)
            {
                Console.WriteLine("You can install this application");
                return true;
            }
            else
            {
                if (app.requiredRAM > ram.totalGigabytes)
                {
                    Console.WriteLine("You do not have enought RAM");
                }
                else
                {
                    Console.WriteLine("You do not have enough available storage");
                }
                return false;
            }
        }

        public bool CheckGameRequirements(Games game, HardDrive hardDrive, RAM ram,
            GPU gpu)
        {
            if ((game.requiredRAM <= ram.totalGigabytes)
                && (game.requiredStorage <= hardDrive.availableStorage)
                && (game.requiredEffectiveMemory <= ram.totalGigabytes))
            {
                Console.WriteLine("You can install this Game");
                return true;
            }
            else
            {
                if (game.requiredRAM > ram.totalGigabytes)
                {
                    Console.WriteLine("You do not have enought RAM");
                }
                if (game.requiredStorage > hardDrive.availableStorage)
                {
                    Console.WriteLine("You do not have enough available storage");
                }
                else
                {
                    Console.WriteLine("Your GPU is not powerful enough to run this game");
                }
                return false;
            }

        }
    }
}
