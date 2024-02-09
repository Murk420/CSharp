abstract class Ranged : Unit
{

    
    
    //Range
    protected int RNG { get; set; }
    //Accuracy
    protected int ACC { get; set; }
    public override void Attack(Unit EnemyUnit)
    {
        int HitChance = Dmg.GetNumber();
        if (HitChance >= 6)
        {
            Console.WriteLine("Succesful Hit!");
            EnemyUnit.Defend(this);
            if (HitChance >= 12)
            {
                Console.WriteLine("Critical Hit!");
                EnemyUnit.Defend(this);
                EnemyUnit.Defend(this);                
            }
        }
        else if (HitChance <= 1)
        {
            Console.WriteLine("Epic Fail!");
            HP -= 1;
        }
        else { Console.WriteLine("Swing and Miss!"); }
    }
    public override void Defend(Unit EnemyUnit)
    {
        int HitChance = ChanceDice.GetNumber();
        if (HitChance > 8)
        {
            Console.WriteLine("Block Failed!");
            HP -= EnemyUnit.DmgDice.GetNumber();
        }
        else if (HitChance >= 12)
        {
            Console.WriteLine("Epic Defense");
        }
        else if (HitChance <= 1)
        {
            Console.WriteLine("Horrible Defense!");
            HP -= (EnemyUnit.DmgDice.GetNumber() + 2);
        }
        else
        {
            Console.WriteLine("Great Defense!");
            HP -= (EnemyUnit.DmgDice.GetNumber() / 2);
        }
    }
}
sealed class RangedHuman : Ranged
{
    public RangedHuman()
    {
        Dmg = new Bag(5);
    }
}
sealed class RangedVamp : Ranged
{
  
}
sealed class RangedWolf : Ranged
{
  
}

