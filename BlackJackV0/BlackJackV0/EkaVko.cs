using System;
using System.Text.RegularExpressions;
namespace JAMK.IT
{
    class EkaVko
    {
        public static void Eka()
        {

            teht1();
            teht2();
            teht3();
            teht4();
            teht5();
            teht6();
            teht7();
            teht8();
            teht9();
            teht10();
            teht11();
            teht12();
            teht13();
            teht14();
            teht15();
            teht16();
            teht17();
            teht18();
            teht19();
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
            Console.WriteLine("Anna sekunnit jotka haluat kääntää tunneiksi, minuuteiksi ja sekunneiksi > ");
            int Secs = int.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(Secs);
            string TimeString = time.ToString(@"hh\:mm\:ss");
            Console.WriteLine("{0} tuntia {1} minuuttia {2} sekuntia", time.Hours, time.Minutes,time.Seconds);


        }
        static void teht6()
        {
            /*
            Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.*/
            Console.WriteLine("\n\n------ 6 TEHTÄVÄ -----");
            Console.WriteLine("Anna matka kilometreinä josta haluat laskea kulutuksen ja kustannukset: ");
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
            Console.WriteLine("HEP Machine: ");
            int[] IntArray = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] % 2 == 0) { Console.WriteLine("HEP"); }
            }

        }
        static void teht11()
        {
            /*  Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
                *
                **
                ***
                ****
                *****
                Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.*/

            Console.WriteLine("\n\n------ 11 TEHTÄVÄ -----");
            Console.WriteLine("Anna kokonaisluku: ");
            int Luku = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Luku; i++){
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void teht12()
        {
            /* Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
            Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.*/
            Console.WriteLine("\n\n------ 12 TEHTÄVÄ -----");
            Console.WriteLine("Anna 5 kokonaislukua jotka haluat suuruusjärjestykseen: ");
            const int Amount = 5;
            int[] IntArray = new int[Amount];

            for (int i = 0; i < Amount; i++)
            {
                IntArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suuruusjärjestyksessä: ");
            Array.Sort(IntArray);
            for (int i = Amount-1; i >= 0; i--)
            {
                Console.WriteLine(IntArray[i]);
            }

        }
        static void teht13()
        {
            /* Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, 
            että summasta on vähennetty pois pienin ja suurin tyylipiste.*/
            Console.WriteLine("\n\n------ 13 TEHTÄVÄ -----");
            Console.WriteLine("Anna 5 kokonaislukua jotka haluat laskea yhteen vähentäen pienimmän ja isoimman pois.: ");
            const int Amount = 5;
            int[] IntArray = new int[Amount];

            for (int i = 0; i < Amount; i++)
            {
                IntArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(IntArray);
            int Summa = 0;
            for (int i = Amount-2; i > 0; i--)
            {
                Summa += IntArray[i];
            }

            Console.WriteLine("Summa: "+Summa);
        }
        static void teht14()
        {
            /* Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
            Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:*/
            Console.WriteLine("\n\n------ 14 TEHTÄVÄ -----");
            Console.WriteLine("Anna opiskelijoiden arvosanat ohjelmointi opintojaksosta: ");
            int Arvosana = 1;
            int arvosana0 = 0;
            int arvosana1 = 0;
            int arvosana2 = 0;
            int arvosana3 = 0;
            int arvosana4 = 0;
            int arvosana5 = 0;

            while (Arvosana >= 0 && Arvosana <6)
            {
                Console.WriteLine("Anna numero(0-5): ");
                Arvosana = int.Parse(Console.ReadLine());
                switch (Arvosana)
                {
                    case 0:
                        arvosana0++;
                        break;
                    case 1:
                        arvosana1++;
                        break;
                    case 2:
                        arvosana2++;
                        break;
                    case 3:
                        arvosana3++;
                        break;
                    case 4:
                        arvosana4++;
                        break;
                    case 5:
                        arvosana5++;
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("Arvosanat:");
            Console.Write("0:");
            for (int i = 0; i < arvosana0; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n1:");
            for (int i = 0; i < arvosana1; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n2:");
            for (int i = 0; i < arvosana2; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n3:");
            for (int i = 0; i < arvosana3; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n4:");
            for (int i = 0; i < arvosana4; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n5:");
            for (int i = 0; i < arvosana5; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");


        }
        static void teht15()
        {
            /*Tee ohjelma, joka tulostaa seuraavanlaisen kuvion.Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö. Anna Luku > 7[Enter]
                        *
                       ***
                      *****
                     *******
                    *********
                        *
                        *                       */
            Console.WriteLine("\n\n------ 15 TEHTÄVÄ -----");
            Console.WriteLine("Anna kokonaisluku:  ");
            int Luku = int.Parse(Console.ReadLine());
            int Luku2 = 1;
            int Luku3 = Luku-2;
            int TreeStump = Luku3;


            for (int i = 0; i < Luku-2; i++)
            {
                //tyhjä tila vasemmalle
                for (int j = 0; j < Luku3; j++)
                {
                    Console.Write(" ");
                }
                //tulostaa kuusen oksat
                for (int x = 0; x < Luku2; x++)
                {
                    Console.Write("*");
                }
                Luku2 += 2;
                Luku3 -=1;
                Console.Write("\n");
            }
            // tekee kuusen jalan
            for (int i = 0; i < 2; i++)
                {
                for (int j = 0; j < TreeStump; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }


        }
        static void teht16()
        {
            /*Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
            Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
            Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle. 
            PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators. */
            Console.WriteLine("\n\n------ 16 TEHTÄVÄ -----");
            Console.WriteLine("Yritä arvata koneen arpoma kokonaisluku 0 ja 100 väliltä:  ");
            Random rand = new Random();
            int Answer=rand.Next(0, 100);
            int UserGuess = 150;
            int Guesses = 0;

            while(UserGuess != Answer)
            {
                UserGuess = int.Parse(Console.ReadLine());
                Guesses++;
                if (UserGuess > Answer)
                {
                    Console.WriteLine("Lukusi on suurempi kuin oikea vastaus");
                }
                else if (UserGuess < Answer)
                {
                    Console.WriteLine("Lukusi on pienempi kuin oikea vastaus");
                }
                else
                    Console.WriteLine("Oikea vastaus!");
            }

            Console.WriteLine("Tarvitsit {0} arvausta.", Guesses);


        }
        static void teht17()
        {
            /*Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot 
            suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö. */
            Console.WriteLine("\n\n------ 17 TEHTÄVÄ -----");

            int[] FirstArray = { 10, 20, 30, 40, 50 };
            int[] SecondArray = { 5, 15, 25, 35, 45 };
            int[] ThirdArray = new int[10];
            FirstArray.CopyTo(ThirdArray, 0);
            SecondArray.CopyTo(ThirdArray, 5);
            Console.WriteLine("Ensimmäinen taulukko: ");
            Array.Sort(ThirdArray);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(FirstArray[i]);
            }
            Console.WriteLine("Toinen taulukko: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(SecondArray[i]);
            }
            Console.WriteLine("Kolmas taulukko: ");
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(ThirdArray[i]);
            }
        }
        static void teht18()
        {
            /*Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). 
            Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi. */
            Console.WriteLine("\n\n------ 18 TEHTÄVÄ -----");
            Console.WriteLine("Anna merkkijono palindromi tarkastusta varten");
            string RegRemove = "[^a-zA-Z0-9]";
            string UserInput = Console.ReadLine().ToLower();
            int length = UserInput.Length;
            bool PalTest = false;

            // uses RegEx to remove all non numbers/letters
            UserInput = Regex.Replace(UserInput, RegRemove, "");

            Console.Write(UserInput);//test
            length = UserInput.Length;

            for (int i = 0; i < length/2; i++)
            {
                if (UserInput[i] != UserInput[length - i-1])
                    PalTest = false;
                else
                    PalTest = true;
               
            }

            if (PalTest == true) { Console.WriteLine(" On Palindromi"); }
            else {Console.WriteLine(" Ei ole palindromi"); }


        }
        static void teht19()
        {
            /*
            Tee tekstipohjainen Hirsipuu - peli.Voit kovakoodata arvattavan sanan ja toteuta looppi, 
            jossa käyttäjältä kysytään seuraavaa kirjainta. Muista näyttää aina kirjaimen jälkeen oikein arvatut kirjaimet sanan oikealla kohdalla
            (käytä esim _ - alaviivaa ei arvattujen kirjainten kohdalla).Voit näyttää myös jo arvatut ei käytetyt -kirjaimet.
            Päätä itse milloin pelaaja joutuu hirteen. */

            Console.WriteLine("\n\n------ 19 TEHTÄVÄ -----");
            Console.WriteLine("Hirsipuu peli, arvaa kirjaimia. 10 kertaa voit arvata");
            char[] Answer = { 'H', 'i', 'r', 's', 'i', 'p', 'u', 'u' };
            char[] Answer2 = { 'K', 'o', 's', 'm', 'i', 'n', 'e', 'n' };
            char[] Answer3 = { 'O', 'h', 'j', 'e', 'l', 'm', 'a', 't' };

            Random rand = new Random();

            char[][] AllAns = new char[3][];
            AllAns[0] = Answer;
            AllAns[1] = Answer2;
            AllAns[2] = Answer3;

            int AnsPicker = rand.Next(1, 3);

            char[] OutPut = { '_', '_', '_', '_', '_', '_', '_', '_' };

            char Guess = ' ';
            int Length = AllAns[AnsPicker].Length;
            int Amount = 0;
            int count = 10;

            while(count != 0)
            {
                
                Guess = char.Parse(Console.ReadLine());

                for (int i = 0; i < Length; i++)
                {
                    if (Guess.Equals(char.ToLower(AllAns[AnsPicker][i]))) {
                        if (Guess != OutPut[i]) {
                            OutPut[i] = AllAns[AnsPicker][i];
                            Amount++;
                        }
                    }
                    
                }

                Console.WriteLine(OutPut);

                if (Amount == Length) { Console.WriteLine("You win!"); count = 0; }
                else { count--; Console.WriteLine(count); }
                if (count == 0 && Amount != Length) { Console.WriteLine("You Lose!"); }
            }
        }
    }
}
