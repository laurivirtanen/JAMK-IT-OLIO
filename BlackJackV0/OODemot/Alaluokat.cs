using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OODemot
{
    class Alaluokat
    {

        public static void BikeQuest() {
            Bike mopedi = new Bike("Pyörö", "Mahtava", "Keltainen", 252, true, "upeeta");
            Console.WriteLine(mopedi.ToString());
            Boat boaty = new Boat("Laiva", "McBoaty", "HotPink", 1992, 4, "Motorboater");
            Console.WriteLine(boaty.ToString());
        }

        public static void BossTester()
        {
            Boss lasse = new Boss("Lasse Mortensen", "Koodaaja", 5000, 53533, "mopedi");
            Employee empl = new Employee("Eka", "Työtön", 2555f);
            Console.WriteLine("Employee: ");
            Console.WriteLine(empl.ToString());
            Console.WriteLine("Bossman: ");
            Console.WriteLine(lasse.ToString());
            empl = new Employee(empl.Name, empl.Profession, (empl.Salary * 1.1f));
            Console.WriteLine("Employee: ");
            Console.WriteLine(empl.ToString());
        }

        public static void Vahvistaja()
        {
            Vahvistin vahvari = new Vahvistin(40);
            bool AreWeThereYet = true;
            while (AreWeThereYet == true)
            {
                string line = Console.ReadLine();
                int number;
                bool result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    vahvari.VolumeSelector = number;
                    Console.WriteLine("Vahvistimen volume on: {0}", vahvari.VolumeSelector.ToString());

                } else { Console.WriteLine("YOU MADE IT!"); AreWeThereYet = false; }


            }

        }
        public static void Tester()
        {
            

            DynamoHissi testi = new DynamoHissi("Musta", 1);
           

            bool AreWeThereYet = false;
            Console.WriteLine("Non number to quit the Elevator Simulator 2017");
            while (AreWeThereYet == false)
            {
                Console.Write("The Elevator is on floor number {0} . Which floor do you wanna go to > ", testi.FloorSelector);
                string line = Console.ReadLine();
                int number;
                bool result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    testi.FloorSelector = number;

                }
                else { Console.WriteLine("YOU MADE IT!"); AreWeThereYet = true; }

                

            }
        }
        
        
        
        
    }
}
