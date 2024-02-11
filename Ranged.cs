abstract class Ranged : Unit
{
    new IRandomProvider Dmg = new Bag(5, true);
    Bag Def = new(5, false);
    //Swiftness
    protected int SWFT { get; set; }
    //Accuracy
    protected int ACC { get; set; }
    public override void Attack(Unit EnemyUnit)
    {
        dmgDealt = (Dmg.GetNumber() + weatherModifier);
        int HitChance = Random.Shared.Next(ACC, 101);
        if (HitChance >= 50)
        {
            if (HitChance >= 90)
            {
                Console.WriteLine(" Critical Hit!");
                Console.WriteLine();
                EnemyUnit.Defend(this);
                if (EnemyUnit.HP > 0)
                {
                    Console.WriteLine();
                    EnemyUnit.Defend(this);
                }
                Heal();
            }
            else
            {
                Console.WriteLine(" Succesful Shot!");
                Console.WriteLine();
                EnemyUnit.Defend(this);
            }
        }
        else if (HitChance <= (ACC + 8))
        {
            Console.WriteLine(" Epic Fail! XD");
            HP -= 1;
        }
        else { Console.WriteLine(" Missed Shot!"); }
    }
    public override void Defend(Unit EnemyUnit)
    {
        int dodgeChance = Random.Shared.Next(SWFT, 101);
        if (dodgeChance >= 95)
        {
            Console.WriteLine(" Nice Dodge!");
        }
        else
        {
            int Reduce = Def.GetNumber();
            switch (Reduce)
            {
                case 1:
                    Console.WriteLine(" Horrible Defense");
                    break;
                case 3:
                    Console.WriteLine(" Bad Defense");
                    break;
                case 5:
                    Console.WriteLine(" Great Defense");
                    break;
                case 8:
                    Console.WriteLine(" Epic Defense");                    
                    break;
            }
            if (Reduce > EnemyUnit.dmgDealt) { Reduce = EnemyUnit.dmgDealt; }
            HP -= (EnemyUnit.dmgDealt - Reduce);
        }
    }
}
sealed class RangedHuman : Ranged
{
    public RangedHuman()
    {
        GiveName();
        Racist = Race.Human;
        hp = 100;
        maxHp = hp;
        res = 7;
        caca = 21;
        ACC = 8;
        SWFT = 8;
    }
}
sealed class RangedVamp : Ranged
{
    public RangedVamp()
    {
        GiveName();
        Racist = Race.Vampire;
        hp = 90;
        maxHp = hp;
        res = 5;
        caca = 15;
        ACC = 12;
        SWFT = 8;
    }
}
sealed class RangedWolf : Ranged
{
    public RangedWolf()
    {
        GiveName();
        Racist = Race.Werewolf;
        hp = 115;
        maxHp = hp;
        res = 3;
        caca = 10;
        ACC = 4;
        SWFT = 12;
    }
}

