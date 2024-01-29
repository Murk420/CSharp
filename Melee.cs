abstract class Melee : Unit
{
    //Strength
    protected int STR { get; set; }
    //Armor
    protected int ARM { get; set; }
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
sealed class MeleeHuman : Melee
{
    protected override void SetStats()
    {
        Racist = Race.Human;
        base.SetStats();
        STR = 11;
        ARM = 15;
    }
}
sealed class MeleeVamp : Melee
{
    protected override void SetStats()
    {
        Racist = Race.Vampire;
        base.SetStats();
        STR = 13;
        ARM = 8;
    }

}
sealed class MeleeWolf : Melee
{
    protected override void SetStats()
    {
        Racist = Race.Werewolf;
        base.SetStats();
        STR = 15;
        ARM = 10;
    }
}