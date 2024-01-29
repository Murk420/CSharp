abstract class Psychic : Unit
{
    //Intelligence
    public virtual int INT { get; protected set; }
    //Insight
    protected virtual int INS { get; set; }
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

sealed class PsyHuman : Psychic
{
    protected override void SetStats()
    {
        Racist = Race.Human;
        base.SetStats();
        INT = 13;
        INS = 9;
    }
}
sealed class PsyVamp : Psychic
{
    protected override void SetStats()
    {
        Racist = Race.Vampire;
        base.SetStats();
        INS = 14;
        INT = 12;
    }
}
sealed class PsyWolf : Psychic
{
    protected override void SetStats()
    {
        Racist = Race.Werewolf;
        base.SetStats();
        INT = 8;
        INS = 13;
    }
}