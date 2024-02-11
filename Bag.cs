struct Bag : IRandomProvider
{
    //List of integers inside the Bag
    public List<int> Content = new List<int>();
    //Damage Dealing integers
    public List<int> Dmg = new List<int>();
    //Damage Reducing integers
    public List<int> Def = new List<int>();
    //Integers removed from the bag
    public List<int> DiscardPile = new List<int>();
    //How many integers the Bag contains
    int amount;

    public Bag(int amount, bool type)
    {
        this.amount = amount;
        int rnd = Random.Shared.Next(0, 4);
        switch (rnd)
        {
            case 0: Dmg.Add(1); Def.Add(8); break;
            case 1: Dmg.Add(3); Def.Add(5); break;
            case 2: Dmg.Add(5); Def.Add(3); break;
            case 3: Dmg.Add(8); Def.Add(1); break;
        }
        if (type == true)
        {
            FillBag(true);
        }
        else
        {
            FillBag(false);
        }
    }

    //First Filling of the Bag
    public void FillBag(bool type)
    {
        if (type == true)
        {
            for (int i = 0; i < amount; i++)
            {
                int rnd = Random.Shared.Next(0, Dmg.Count);
                Content.Add(Dmg[rnd]);
            }
        }
        else
        {
            for (int i = 0; i < amount; i++)
            {
                int rnd = Random.Shared.Next(0, Def.Count);
                Content.Add(Def[rnd]);
            }
        }
    }
    //Picking an Integer from the Bag and Removing it
    public int GetNumber()
    {
        if (Content.Count == 0)
        {
            Refill();
        }
        int Pick = Random.Shared.Next(0, Content.Count);
        int Show = Content[Pick];
        DiscardPile.Add(Content[Pick]);
        Content.Remove(Content[Pick]);
        return Show;
    }
    //Returning Discarded Integers into the Bag
    public void Refill()
    {
        for (int i = 0; i < DiscardPile.Count; i++)
        {
            Content.Add(DiscardPile[i]);
            DiscardPile.Remove(DiscardPile[i]);
        }
    }
}





