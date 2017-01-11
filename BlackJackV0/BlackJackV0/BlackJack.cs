using System;
using System.Collections.Generic;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{

    class BlackJack
    {

        public static void PlayBlackJack()
        {

            Random rand = new Random();
            bool looping = true;
            int myNumber = rand.Next(1, 21); 
            int theirNumber;

            System.Console.WriteLine("*** BlackJack! ***");
            System.Console.Write("Can you beat my number? Enter any number between 1-21: (x and exit quits the game)");
            //reading and converting   
            theirNumber = 0;
            //comparing that given umber is valid
            List<int> userInts = new List<int>();

            while (looping==true)
            {

                for (int i = 0; i < 1; i++)
                {
                    string userValue = Console.ReadLine();
                    if (userValue == "x" || userValue == "exit") looping = false;
                    int userInt;
                    if (int.TryParse(userValue, out userInt))
                    {
                        userInts.Add(userInt);
                        theirNumber += userInt;
                        Console.Write(theirNumber+"\n");
                    }
                }

                if (theirNumber > 21)
                {
                    Console.WriteLine("Im sorry you lose ");
                    theirNumber = 0;
                    myNumber = rand.Next(10, 21);

                }
                if (theirNumber > myNumber)
                {
                    Console.WriteLine("YOU WIN! Dealer had: " + myNumber);
                    theirNumber = 0;
                    
                    myNumber = rand.Next(10, 21);
                }
                else
                {
                    Console.WriteLine("You need to take new card");
                }




            }
        }
    }
}
