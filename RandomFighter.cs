
    public class RandomFighter
    {
        public void Fight()
        {
            Dice die = new(1, 20, 0);
            Deck<int> deck = new(40);
            deck.currentDeck.Clear();
            for (int i = 0; i < deck.size; i++)
            {
                int rnd = Random.Shared.Next(0, 21);
                deck.currentDeck.Enqueue(rnd);
            }
            int DieWins = 0;
            int Tie = 0; 
            int DeckWins = 0;
            while (deck.remaining > 0)
            {
                int deckResult = deck.Peek();
                deck.TryDraw(deck.currentDeck.First());
                int dieResult = die.GetNumber();
                int comparison = deckResult.CompareTo(dieResult);
                if (comparison > 0)
                {
                    DeckWins++;
                }
                if (comparison == 0)
                {
                    Tie++;
                }
                if (comparison < 0)
                {
                    DieWins++;
                }
            }
            Console.WriteLine("Deck Wins: " + DeckWins);
            Console.WriteLine("Die Wins: " + DieWins);
            Console.WriteLine("Ties: " + Tie);
        }
    }

