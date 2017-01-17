using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;


namespace OODemot
{
    class TokaViikko
    {
        static void Main(string[] args)
        {

            Uuni();
            Students();
            Vehicle();
            KolmeKonetta();

        }

        static void Uuni()
        {
            Oven uuni = new Oven();
            uuni.Temperature = 25.5f;
            uuni.OnSwitch();
            uuni.TurnOn(uuni.IsOn, uuni.Temperature);

            Console.WriteLine(uuni.IsOn.ToString() + uuni.Temperature);
        }

        static void Students()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            Student student2 = new Student();

            students.Add(student1);
            students.Add(student2);
            student2.Age = 4;
            student2.Avg = 4.4f;
            student2.firstname = "Daa";
            student2.lastname = "Hortensen";

            student1.Age = 5;
            student1.Avg = 3.4f;
            student1.firstname = "Lasse";
            student1.lastname = "Mortensen";


            foreach (var Student in students)
            {

                Console.WriteLine("--Student--");
                Console.WriteLine(Student.Name);
                Console.WriteLine(Student.Age);
                Console.WriteLine(Student.Avg);
            }
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
