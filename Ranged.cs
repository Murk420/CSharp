abstract class Ranged : Unit
{
    //Range
    protected int RNG { get; set; }
    //Accuracy
    protected int ACC { get; set; }
    public override void Attack(Unit EnemyUnit)
    {
        int HitChance = ChanceDice.Roll();
        if (HitChance >= 6)
        {
            Console.WriteLine("Succesful Hit!");
            EnemyUnit.Defend(this);
            if (HitChance >= 12)
            {
                Console.WriteLine("Critical Hit!");
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
        int HitChance = ChanceDice.Roll();
        if (HitChance > 8)
        {
            Console.WriteLine("Block Failed!");
            HP -= EnemyUnit.DmgDice.Roll();
        }
        else if (HitChance >= 12)
        {
            Console.WriteLine("Epic Defense");
        }
        else if (HitChance <= 1)
        {
            Console.WriteLine("Horrible Defense!");
            HP -= (EnemyUnit.DmgDice.Roll() + 2);
        }
        else
        {
            Console.WriteLine("Great Defense!");
            HP -= (EnemyUnit.DmgDice.Roll() / 2);
        }
    }
}
sealed class RangedHuman : Ranged
{
    protected override void SetStats()
    {
        Racist = Race.Human;
        base.SetStats();
        RNG = 11;
        ACC = 10;
    }
    
}
sealed class RangedVamp : Ranged
{
    protected override void SetStats()
    {
        Racist = Race.Vampire;
        base.SetStats();
        RNG = 12;
        ACC = 15;
    }
}
sealed class RangedWolf : Ranged
{
    protected override void SetStats()
    {
        Racist = Race.Werewolf;
        base.SetStats();
        RNG = 14;
        ACC = 9;
    }
}

