public class Deck<T> where T : struct, IComparable<T>
{
    public int size { get; }
    public int remaining { get; set; }
    public Queue<T> currentDeck;
    public List<T> discardPile;

    public Deck(int Size)
    {
        size = Size;
        remaining = Size;
        currentDeck = new Queue<T>(Size);
        for (int i = 0; i < Size; i++)
        {
            currentDeck.Enqueue(new T());
        }
    }
    public void Shuffle(Queue<T> currentDeck)
    {
        List<T> tempDeck = new();
        foreach (T card in currentDeck)
        {
            tempDeck.Add(currentDeck.First());
            currentDeck.Dequeue();
        }
        for (int i = 0; i < tempDeck.Count + 1;)
        {
            int rnd = Random.Shared.Next(0, discardPile.Count + 1);
            currentDeck.Enqueue(tempDeck[rnd]);
            tempDeck.RemoveAt(rnd);            
        }
    }

    public void Reshuffle()
    {
        for (int i = 0; i < discardPile.Count;)
        {
            int rnd = Random.Shared.Next(0, discardPile.Count + 1);
            currentDeck.Enqueue(discardPile[rnd]);
            discardPile.RemoveAt(rnd);            
        }
    }


    public T Peek()
    {
        return currentDeck.First();
    }

    public bool TryDraw(T drawn)
    {
        if (remaining > 0)
        {
            T card = currentDeck.First();
            discardPile.Add(card);
            currentDeck.Dequeue();
            remaining--;
            return true;
        }
        else
        {
            return false;
        }
    }




}
