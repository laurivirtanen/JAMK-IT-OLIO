using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;


namespace test
{
    class OvenStuff
    {
        public static void UuniOhjelma()
        {
            Uuni();
        }
        static void Uuni()
        {
            Oven uuni = new Oven();
            uuni.Temperature = 25.5f;
            uuni.OnSwitch();
            uuni.TurnOn(uuni.IsOn, uuni.Temperature);

            Console.WriteLine(uuni.IsOn.ToString() + uuni.Temperature);
        }
    }
}
