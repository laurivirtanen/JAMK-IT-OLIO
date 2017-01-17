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

        string[] pesuohjelma = { "Pikapesu - 30min", "Peruspesu - 90min" , "Hienopesu - 150min" };
        public bool IsOn { get; set; }
        private int choice { get; set; }


        public int ValitseOhjelma()
        {
            Console.WriteLine("Tahdotko pestä pyykkiä?(y/n)");
            if (Console.ReadKey().Key == ConsoleKey.Y) { IsOn = true; } else IsOn = false;
            if(IsOn==true)
            {
                for (int i = 0; i < pesuohjelma.Length; i++)
                {
                    Console.Write("\n"+(i+1)+" {0} ", pesuohjelma[i]);
                }
                choice = int.Parse(Console.ReadLine())-1;
                switch (choice)
                {
                
                    default:
                        Console.WriteLine("Valitsit {0}", pesuohjelma[choice]);
                        return choice;
                }
            }
            return 0;
        }

    }

    public class Televisio
    {

        private int channel;
        public bool IsOn { get; set; }
        public bool IsRecording { get; set; }

        public int Channel
        {
            get { return channel; }
            set
            {
                if (IsOn == true) { channel = value;}
                else {
                    Console.Write("\nTV Isn't On\n"); channel = 0;
                }
            }

        }

        public bool OnSwitch()
        { 


            Console.WriteLine("Turn the TV on? (y turns it on)");
            char choice = char.Parse(Console.ReadLine());
            if (choice=='y')
            {
              return IsOn = true;
            }
            else { return IsOn = false; }
        }

        public int ChangeChannel()
        {
            Console.WriteLine("Pick a channel number: ");
            Channel = int.Parse(Console.ReadLine());
            Console.WriteLine(Channel);
            return Channel;
        }
    }

    public class Vehicle
    {
        private string allData;

        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public string AllData{
            get { return allData; }
            set { allData += Name + Speed.ToString() + Tyres.ToString(); }
        }

        public void PrintData()
        {
            Console.WriteLine("Auton nimi: {0} Nopeus: {1} Renkaiden lukumäärä: {2}", Name, Speed, Tyres);
        }

        public string AllDemDatas(string AllData)
        {
            
            Console.WriteLine(AllData);
            return AllData;
        }
    }

    public class Student
    {
        public string firstname;
        public string lastname;


        public int Age { get; set; }
        public float Avg { get; set; }

        public string Name
        {
            get { return firstname + " " + lastname; }

        }
    }

    public class Oven
    {

        private bool isCooking;
        public bool IsOn { get; set; }
        public float Temperature { get; set; }

        private bool IsCooking
        {
            get { return isCooking; }
            set
            {
                if (IsOn == true && (Temperature > 0f && Temperature <=300f) ) { isCooking = true; }
                else {
                    Console.Write("\nERROR\n"); isCooking = false;
                }
            }

        }

        public bool OnSwitch()
        {
          
            char daa;
            Console.WriteLine("Turn the oven on? (y turns it on)");
            daa = char.Parse(Console.ReadLine());

            if (daa == 'y') { Console.WriteLine("OVEN Powering On"); return IsOn = true; }

            else { return false; }
        }

        public bool TurnOn(bool OnCheck, float TempCheck)
        {
            char daa;
            Console.WriteLine("Do you want to start baking?");
            daa = char.Parse(Console.ReadLine());
            if (daa == 'y') {
                OnCheck = true;
                if (OnCheck == true && TempCheck > 0f) { Console.WriteLine("SUCCESS"); return IsCooking = true; }
             else { Console.WriteLine("Im sorry the oven isnt configured correctly"); return false; }

            }
            else Console.WriteLine("Im sorry "); return false;
        }
    }

}
