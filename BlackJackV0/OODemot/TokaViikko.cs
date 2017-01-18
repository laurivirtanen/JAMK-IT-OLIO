using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;


namespace OODemot
{
    public class TokaViikko
    {
        public static void Tokat()
        {

            Uuni();
            Vehicle();
            KolmeKonetta();

        }

        

        

        static void Vehicle()
        {

            Vehicle mopedi = new Vehicle();

            mopedi.Name = "Mopo";
            mopedi.Speed = 25;
            mopedi.Tyres = 2;

            mopedi.AllData = mopedi.AllData;
            mopedi.AllDemDatas(mopedi.AllData);
            mopedi.PrintData();

        }

        static void KolmeKonetta()
        {
            Pesukone pesukone = new Pesukone();
            pesukone.IsOn = true;
            pesukone.ValitseOhjelma();

            Televisio teevee = new Televisio();
            teevee.OnSwitch();
            teevee.Channel = 5;
            teevee.ChangeChannel();

            Kiuas ekaKiuas = new Kiuas();
            ekaKiuas.OnSwitch = true;
            ekaKiuas.Humidity = 15;
            ekaKiuas.Temperature = 70;
            Console.WriteLine("Kosteus {0} Lämpötila {1} ", ekaKiuas.Humidity, ekaKiuas.Temperature);
            Start.Main();
        }
    }
}
