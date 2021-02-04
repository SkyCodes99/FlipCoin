using System;

namespace FlipCoin
{
    class CoinFlip
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hit a key to flip a coin");
                if(Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                }
                Random rnd = new Random();
                int coin = rnd.Next(1, 3);
                string side = " ";
                switch (coin)
                {
                    case 1:
                        side = "Heads";
                        break;
                    case 2:
                        side = "Tails";
                        break;
                }
                Console.WriteLine(side);
                Console.WriteLine("Flip Again?");
                string response = Console.ReadLine();
                if(response.ToLowerInvariant() == "no")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
