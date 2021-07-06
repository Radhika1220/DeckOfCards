using System;

namespace DeckOfCards
{
    class Program:IDeck
    {
        static string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        static string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        static int totalCards = suits.Length * ranks.Length;
        static string[] deckOfCards = new string[totalCards];

        public void shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < totalCards; i++)
            {
                //Random random = new Random();
                int ra = random.Next(0, totalCards);
                String temp = deckOfCards[ra];
                deckOfCards[ra] = deckOfCards[i];
                deckOfCards[i] = temp;
            }
        }
        public void TwoDArray()
        {
            string[,] arr = new string[4, 9];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("For player {0}....", i+1);
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = deckOfCards[k];
                    Console.WriteLine(arr[i, j]);
                    k++;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****DECK OF CARDS PROBLEM*******");
            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    deckOfCards[suits.Length * i + j] = ranks[i] + " of " + suits[j];
                }
            }
            Program obj = new Program();
            obj.shuffle();
            obj.TwoDArray();
        }


    }
}