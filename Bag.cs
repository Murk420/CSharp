struct Bag : IRandomProvider
{
    public List<int> Content = new List<int>();
    public List<int> DiscardPile = new List<int>();
    int Amount;

    public Bag(int amount)
    {
        Amount = amount;
    }

    public void FillBag()
    {
        for (int i = 0; i < Amount; i++)
        {
            Content.Add(i);
        }
    }
    public int GetNumber()
    {
        int Pick = Random.Shared.Next(0, Content.Count);
        int Show = Content[Pick];
        DiscardPile.Add(Content[Pick]);
        Content.Remove(Content[Pick]);
        return Show;
    }
    public void Refill()
    {
        if (Content.Count == 0)
        {
            for (int i = 0; i < DiscardPile.Count; i++)
            {
                Content.Add(DiscardPile[i]);
                DiscardPile.Remove(DiscardPile[i]);
            }
        }
    }
}




