using System.Diagnostics.CodeAnalysis;

public struct Dice : IRandomProvider
{
    //Number of Dice rolled
    uint Scalar;
    //Type of Die(How many pips)
    uint BaseDie;
    //Additive value added to the results
    public int Modifier;
    public Dice(uint scalar, uint baseDie, int modifier)
    {
        Scalar = scalar;
        BaseDie = baseDie;
        Modifier = modifier;
    }
    public int GetNumber()
    {
        int Result = 0;
        for (int i = 0; i < Scalar; i++)
        {
            Result = Random.Shared.Next(1, (int)BaseDie + 1);
        }
        return (Result + Modifier);
    }
    public override string ToString()
    {
        string posimod = "";
        if (Modifier >= 0)
        {
            posimod = "+";
        }
        return Scalar + "D" + BaseDie + posimod + Modifier;
    }
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is Dice)
        {
            if (this.Scalar == ((Dice)obj).Scalar && this.BaseDie == ((Dice)obj).BaseDie && this.Modifier == ((Dice)obj).Modifier)
            {
                return true;
            }
        }
        return false;
    }
    public override int GetHashCode()
    {
        int hash = 69;
        hash ^= Scalar.GetHashCode();
        hash ^= BaseDie.GetHashCode();
        hash ^= Modifier.GetHashCode();
        return hash;
    }
}
