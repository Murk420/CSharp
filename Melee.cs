abstract class Melee : Unit
{     
    //Strength
    protected int STR { get; set; }
    //Armor
    protected int ARM { get; set; }
    public override void Attack(Unit EnemyUnit)
    {
        int HitChance = ChanceDice.GetNumber();
        int DmgDealt;
        if (HitChance >= 6)
        {
            Console.WriteLine("Succesful Hit!");
            DmgDealt = DmgDice.GetNumber();
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
            Console.WriteLine("Great Defense!");
            HP -= (EnemyUnit.Dmg.GetNumber() / 2);
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
            Console.WriteLine("Block Failed!");
            HP -= EnemyUnit.GetNumber();
        }

    }
}
sealed class MeleeHuman : Melee
{

}
sealed class MeleeVamp : Melee
{


}
sealed class MeleeWolf : Melee
{

}