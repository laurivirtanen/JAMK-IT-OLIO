using System;

namespace JAMK.IT
{
    class EkaVko
    {
        public static void Eka()
        {
            teht1();//DONE
            teht2();//TODO
            teht3();
            teht4();
            teht5();
            teht6();
            teht7();
            teht8();
            teht9();
            teht10();
        }

        static void teht1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme).
            //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
            Console.WriteLine("------ 1 TEHTÄVÄ -----");
            Console.WriteLine("Anna luku 1, 2 tai 3");
            int kysy = int.Parse(Console.ReadLine());
            switch (kysy)
            {
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                default:
                    Console.WriteLine("Joku muu luku.");
                    break;
            }
        }
        static void teht2()
        {
            Console.WriteLine("\n\n------ 2 TEHTÄVÄ -----");
            /*Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan 
            (pistemäärä kysytään ja ohjelma tulostaa numeron):*/
            Console.WriteLine("Anna pistemäärä(0-12) > ");
            int Points = int.Parse(Console.ReadLine());
            switch (Points)
            {
                case 0:
                case 1:
                    Console.WriteLine("Koulunumero on 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Koulunumero on 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Koulunumero on 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Koulunumero on 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Koulunumero on 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Koulunumero on 5");
                    break;
                default:
                    break;
            }
        }
        static void teht3()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
            Console.WriteLine("\n\n------ 3 TEHTÄVÄ -----");
            Console.WriteLine("Anna Kolme numeroa joista haluat summan ja keskiarvon: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());

            Console.WriteLine("Summa: " + (a + b + c)) ;
            Console.WriteLine("Keskiarvo: " + (((a + b + c)/3)));
            
        }
        static void teht4()
        {
            Console.WriteLine("\n\n------ 4 TEHTÄVÄ -----");
            /* Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
            jos se on 18 - 65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".*/
            Console.WriteLine("How old are you?");
            int Age = int.Parse(Console.ReadLine());
            if (Age < 18) { Console.WriteLine("Child."); }
            else if (Age <= 65 && Age >= 18) { Console.WriteLine("Adult."); }
            else Console.WriteLine("Senior");
        }
        static void teht5()
        {
            /*Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
            Esimerkkitoiminta:
            Anna sekunnit > 3661 [Enter]
            Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekuntti*/
            Console.WriteLine("\n\n------ 5 TEHTÄVÄ -----");
            Console.WriteLine("Anna sekunnit > ");
            double Secs = double.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(Secs);
            string TimeString = time.ToString(@"hh\:mm\:ss\:fff");
            Console.Write(TimeString);
            


        }
        static void teht6()
        {
            /*
            Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.*/
            Console.WriteLine("\\n------ 6 TEHTÄVÄ -----");
            Console.WriteLine("Anna matka josta haluat laskea kulutuksen ja kustannukset: ");
            double price = 1.595;
            double Mileage = (7.02 / 100);
            double matka = double.Parse(Console.ReadLine());

            Console.WriteLine("Bensaa kuluu {0:0.0}l ja kustannukset ovat {1:0.0} euroa", (matka * Mileage), ((matka * Mileage) * price));

        }
        static void teht7()
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi.Vuosiluku kysytään käyttäjältä.
            Console.WriteLine("\n\n------ 7 TEHTÄVÄ -----");
            Console.WriteLine("Karkausvuosi testaaja(0:lla pääset pois). Anna vuosiluku: ");
            int Year = int.Parse(Console.ReadLine());
            while (Year!=0) {
            if (Year % 4 == 0)
            {
                if(Year%100 != 0)
                {
                    Console.WriteLine("Karkausvuosi");
                }
                else if (Year % 400 == 0)
                {
                    Console.WriteLine("Karkausvuosi");
                }
                else { Console.WriteLine("Ei ole Karkausvuosi"); }
            }
            else { Console.WriteLine("Ei ole Karkausvuosi"); }
            Year = int.Parse(Console.ReadLine());
            }
        }
        static void teht8()
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            Console.WriteLine("\n\n------ 8 TEHTÄVÄ -----");
            Console.WriteLine("Anna kolme kokonaislukua niin saat selville suurimman: ");
            int[] Koot = new int[3];
            Koot[0] = int.Parse(Console.ReadLine());
            Koot[1] = int.Parse(Console.ReadLine());
            Koot[2] = int.Parse(Console.ReadLine());
            Array.Sort(Koot);
            Console.WriteLine("Isoin numero on: {0}",Koot[2]);
        }
        static void teht9()
        {
            // Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.Ohjelman tulee tulostaa syötettyjen lukujen summa.
            Console.WriteLine("\n\n------ 9 TEHTÄVÄ -----");
            Console.WriteLine("Anna lukuja jotka haluat laskea yhteen(0 lopettaa): ");
            int AskedNumber = int.Parse(Console.ReadLine());
            int AllNumbers = 0;

            while (AskedNumber != 0)
            {
                AllNumbers += AskedNumber;
                AskedNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lukujen summa on: {0}", AllNumbers);
        }
        static void teht10()
        {
            /*Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
            Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.*/

            Console.WriteLine("\n\n------ 10 TEHTÄVÄ -----");
            Console.WriteLine("Anna lukuja jotka haluat laskea yhteen(0 lopettaa): ");
            int[] IntArray = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] % 2 == 0) { Console.WriteLine("HEP"); }
            }

        }
    }
}
