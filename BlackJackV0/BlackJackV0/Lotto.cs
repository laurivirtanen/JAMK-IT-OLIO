using System;
using System.Linq;
//
namespace JAMK.IT
{
    class Lottery
    {
        
        public static void PlayLotto()
        {

            Random rand = new Random();
            const int LOTTO = 7;
            int[] Numbers = new int[LOTTO];
            int temp = 0;
            int[] Winning = new int[LOTTO];

            Console.Write("How many lines you want to make? ");
            int userNumber = int.Parse(Console.ReadLine());

            //mainloop looppaa niin monesti kun käyttäjä haluaa
            for (int i = 0; i < userNumber; i++)
            {
                for (int j = 0; j < LOTTO; j++)
                {

                    do
                    {
                        temp = rand.Next(1, 40);
                    } while (Numbers.Contains(temp));

                    Numbers[j] = temp;
                }


                Array.Sort(Numbers);

                Console.WriteLine("\n ");
                for (int k = 0; k < LOTTO; k++)
                {
                    Console.Write(Numbers[k] + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
