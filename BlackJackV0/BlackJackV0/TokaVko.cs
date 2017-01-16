using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class TokaVko
    {
        public static void Toka()
        {
            teht1();
        }
        
        static void teht1() {

            Kiuas prototype = new Kiuas();
            int test;
            Console.WriteLine("Haluatko laittaa kiukaan päälle? y/n? ");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                prototype.OnSwitch = true;
                while(prototype.OnSwitch == true)
                {
                    Console.WriteLine("Kiukaan lämpötila: {0} c Kosteus: {1} %", prototype.Temperature, prototype.Humidity);
                    Console.Write("Tahdotko muuttaa lämpötilaa(1) tai kosteutta(2)? 5 sammuttaa kiukaan.");
                    test = int.Parse(Console.ReadLine());
                    switch (test)
                    {
                        case 1:
                            Console.WriteLine("Kiukaan lämpötila: {0} c Kosteus: {1} %", prototype.Temperature, prototype.Humidity);
                            prototype.Temperature = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Kiukaan lämpötila: {0} c Kosteus: {1} %", prototype.Temperature, prototype.Humidity);
                            prototype.Humidity = int.Parse(Console.ReadLine());
                            break;
                        case 5:
                            prototype.OnSwitch = false;
                            break;
                        default:
                                break;
                    }

                }
            }
        }

        
    }
}
