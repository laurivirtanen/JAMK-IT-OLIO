using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;


namespace OODemot
{
    class KiuasTehtava
    {
        static void Main(string[] args)
        {
            JAMK.IT.Kiuas ekaKiuas = new Kiuas();

            ekaKiuas.OnSwitch = true;
            ekaKiuas.Humidity = 15;
            ekaKiuas.Temperature = 70;

            Console.WriteLine("Kosteus {0} Lämpötila {1} ", ekaKiuas.Humidity, ekaKiuas.Temperature);
            JAMK.IT.Start.Main();

        }
    }
}
