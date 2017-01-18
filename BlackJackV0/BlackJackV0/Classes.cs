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

        public Student(string fName, string lName, int age, float avg){
            firstname = fName;
            lastname = lName;
            Age = age;
            Avg = avg;

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

    public class Hissi
    {
        private int maxFloor = 5;
        private int minFloor = 1;

        private int floor;

        public int FloorSelector
        {
            get { return floor; }
            set { if (value <= maxFloor && value >= minFloor) { floor = value; }
               
            } 
        }
        

    }

    public class DynamoHissi : Hissi
    {
        public string Color { get; set; }

        public DynamoHissi()
        {
        }
        public DynamoHissi(string lallalaa, int Valinta)
        {
            FloorSelector = Valinta;
            Color = lallalaa;
        }
    }

    public class Vahvistin
    {
        private int maxVolume = 100;
        private int minvolume = 0;

        private int volume;

        public int VolumeSelector
        {
            get { return volume; }
            set
            {
                if (value < minvolume) { volume = 0; }
                else if (value > maxVolume) { volume = 100; }
                else { volume = value; }


            }
        }

        public Vahvistin()
        {

        }

        public Vahvistin(int vol)
        {
            volume = vol;

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        public Employee() { }
        public Employee(string name, string prof, double sal)
        {
            Name = name;
            Profession = prof;
            Salary = sal;
        }
        public override string ToString()
        {
            return Name + " " + Profession + " " + Salary;
        }
    }
    public class Boss : Employee
    {
        public int Bonus { get; set; }
        public string Car { get; set; }

        public Boss() { }
        public Boss(string name, string prof, double sal, int bon, string car) : base(name, prof, sal)
        {
            Bonus = bon;
            Car = car;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Bonus + " " + Car;
        }

    }

    public class Ajoneuvo
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }

    public class Bike : Ajoneuvo
    {
        public bool HasGears { get; set; }
        private string gearModel;

        public string GearModel {
            get { return gearModel; }
            set { if (HasGears == true) gearModel = value; else gearModel = " ";  } }


        public Bike(string name,string model, string color, int year, bool gears, string gModel)
        {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
            HasGears = gears;
            GearModel = gModel;
        }

        public override string ToString()
        {
            return "Bike info: \n\t Name: "+ Name + " " + Model + " " + Color + " Year:" + Year + " Gears: " + HasGears + " Gear Model: " ;
        }
    }
    public class Boat : Ajoneuvo
    {
        public int SeatCount { get; set; }
        private string BoatType { get; set; }


        public Boat(string name, string model, string color, int year, int seats, string boatType)
        {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
            SeatCount = seats;
            BoatType = boatType;
        }

        public override string ToString()
        {
            return "Boat information: \n \t Name: "+ Name + "| Model: " + Model + "| Color: " + Color + "| Year: " + Year + "| Seats: " + SeatCount + "| BoatType: ";
        }
    }

    public class Radio
    {
        private const float minfreq = 2000;
        private const float maxfreq = 26000;
        private float volume = 0;
        private float frequency = minfreq;
        public bool IsRadioOn { get; set; }
        public float Volume
        {
            get { return volume; }
            set
            {
                if (IsRadioOn == true) { if (value >= 0f && value <= 10f) volume = value;}
               
            }
        }
        public float Frequency
        {
            get { return frequency; }
            set { if(IsRadioOn == true) {
                    if (value > maxfreq) { frequency = minfreq; }
                    else if (value < minfreq) { frequency = maxfreq; }
                    else { frequency = value; }
                }
            }
        }

        public Radio() { }
        public Radio(float vol, float freq, bool on)
        {
            Volume = vol;
            Frequency = freq;
            IsRadioOn = on;
        }
    }

}
