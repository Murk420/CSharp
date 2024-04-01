using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

public class GenericDice<T> where T : IComparable<T>
{
    //Number of Dice rolled
    public uint Scalar;
    //Type of Die (How many sides)
    public uint BaseDie;
    //What is on the dice
    public T[] content;        
    //public T GetSomething()
    //{
    //    T result;
    //    for (int i = 0; i < Scalar; i++)
    //    {
    //        int sideLanded = Random.Shared.Next(0, content.Length + 1);
    //        return content[sideLanded];
    //    }
    //}
    public override string ToString()
    {
        return Scalar + "D" + BaseDie;
    }
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is GenericDice<T> dice)
        {
            if (Scalar == dice.Scalar && BaseDie == dice.BaseDie)
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
        return hash;
    }
}

public class Dice : GenericDice<int>
{
    //Number of Dice rolled
    public uint Scalar;
    //Type of Die(How many pips)
    public uint BaseDie;
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
        int result = 0;
        for (int i = 0; i < Scalar; i++)
        {
            result += Random.Shared.Next(1, (int)BaseDie + 1);            
        }
        return result + Modifier;
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
        if (obj is Dice dice)
        {
            if (Scalar == dice.Scalar && BaseDie == dice.BaseDie && Modifier == dice.Modifier)
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
