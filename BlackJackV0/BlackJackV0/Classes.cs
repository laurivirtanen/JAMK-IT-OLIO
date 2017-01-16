using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JAMK.IT
{
    public class Kiuas
    {
        
        int humidity;

        public bool OnSwitch { get; set; }
        public int Temperature { get; set; }
        public int Humidity
        {
            get { return humidity; }
            set
            {
                if (humidity < 20 || humidity > 100)
                {
                    humidity = 20;
                }
                else humidity = value;
            }
        }
    }

    public class Pesukone
    {
        int[] pesuohjelma = new int[3];
        public bool IsOn { get; set; }
        public int MyProperty { get; set; }



    }
}
