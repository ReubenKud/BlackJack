namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dice Randomizer
            Random rand = new Random();
            int DiceThrow = rand.Next(1, 7);
            
            Random dealerrand = new Random();
            int DealerDiceThrow = dealerrand.Next(1,7);

            //Story 
            Console.WriteLine("You are at a casino in Las Vegas called Active Vision of Blitz & Cards to make back money you lost at another casino, ");
            Console.WriteLine("Electronic All-in Games. ");
            Console.WriteLine("In the casino you are met by a dealer who has two dies and more probably chips than Pringles produces in a year.");
            Console.WriteLine();
            Console.WriteLine("-You there! Do you want to play blackjack?");
            Console.WriteLine();
            Console.WriteLine("Since you don't have a better way to gamble away the non-existent money you have, you decide to play.");
            Console.WriteLine();
            Console.WriteLine("-Do you want to hit or stay?");
            //If the player wants to hit or stay
            string gambling = Console.ReadLine();
            int playerSum = 0;
            int dealerSum = 0;
            while (gambling.ToLower() != "stay")
            {
                if (playerSum >= 21 || dealerSum >= 21)
                {
                    playerSum += DiceThrow;
                    Console.WriteLine();
                    Console.WriteLine("You got " + DiceThrow + ".");
                    Console.WriteLine("BEEP");
                    break;
                }
                else if (dealerSum >= 17)//If the dealer gets or gets more than 17
                {
                    playerSum += DiceThrow;
                    Console.WriteLine();
                    Console.WriteLine("You got " + DiceThrow + ". You now have " + playerSum + " points.");

                    Console.WriteLine("The Dealer has stopped rolling.");

                    Console.WriteLine();
                    Console.WriteLine("-Y'wanna hit or stay?");
                    gambling = Console.ReadLine();
                }
                else if (dealerSum < 17)
                {
                    playerSum += DiceThrow;
                    dealerSum += DealerDiceThrow;
                    Console.WriteLine();
                    Console.WriteLine("You got " + DiceThrow + ". You now have " + playerSum + " points.");
                    Console.WriteLine("The Dealer got " + DealerDiceThrow + "." );

                    Console.WriteLine();
                    Console.WriteLine("Do you wanna hit or stay?");

                    gambling = Console.ReadLine();

                    DiceThrow = rand.Next(1, 7);
                    DealerDiceThrow = rand.Next(1, 7);
                }
                
                
                
            }
            //The total sum and what happens afterwards
            Console.WriteLine();
            if (dealerSum<17 && dealerSum<playerSum) 
            {
                DealerDiceThrow = rand.Next(1, 7);
                dealerSum += DealerDiceThrow;
                Console.WriteLine("The dealer rolls one last time. He got " + DealerDiceThrow + ".");
                Console.WriteLine("Your total sum: " + playerSum + ".");
                Console.WriteLine("The Dealer's total sum: " + dealerSum + ".");
            } else
            {
                Console.WriteLine("Your total sum: " + playerSum + ".");
                Console.WriteLine("The Dealer's total sum: " + dealerSum + ".");
            }

            
            if (playerSum<dealerSum && playerSum < 21 && dealerSum == 21)
            {
                Console.WriteLine();
                Console.WriteLine("The Dealer got 21, you've lost and now have more debt. LOL");
            } else if (playerSum<dealerSum&& dealerSum < 21)
            {
                Console.WriteLine();
                Console.WriteLine("The Dealer was closer to 21 than you, you've lost and now have more debt. LMAO");
            }
            else if (playerSum>dealerSum && dealerSum<21 &&playerSum==21)
            {
                Console.WriteLine();
                Console.WriteLine("You got 21, you've won. While the dealer stands still in disbelief you take the money and as a responsible adult, you bet all the money away at a Nascar Race. THE END");
            } else if (playerSum>dealerSum&& playerSum<21)
            {
                Console.WriteLine();
                Console.WriteLine("You were closer to 21 than the dealer, you've won. You then decide to buy the entire godamn casino with the money and ");
                Console.WriteLine("fire the dealer and you now make morbillions of dollars per day. THE END");
            }
            else if (playerSum>21&&dealerSum<21)
            {
                Console.WriteLine();
                Console.WriteLine("You got more than 21, you've lost automatically. OOFERS");
            } else if (dealerSum>21 && playerSum<21)
            {
                Console.WriteLine();
                Console.WriteLine("The Dealer got more than 21, you've won automatically. While hearing seeing the results the dealer repeatedly bashes his head against the desk and you take the money and you invest all the money in crypto. THE END");
            }
            else if (playerSum==dealerSum)  
            {
                Console.WriteLine();
                Console.WriteLine("It got tied, so the dealer wins. Tough luck bitch");
            } 
        }
    }
}
