abstract class Melee : Unit
{
    new IRandomProvider Dmg = new Dice(2, 6, 0);
    protected Dice chanceDice = new Dice(1, 10, 0);
    //Strength
    protected int STR { get; set; }
    //Armor
    protected int ARM { get; set; }
    int strModifier = 0;
    int armModifier = 0;
    public Melee()
    {
        for (int i = 0; i < STR; i += 4)
        {
            strModifier += 1;
        }
        for (int i = 0; i < ARM; i += 4)
        {
            armModifier += 1;
        }
    }
    public override void Attack(Unit EnemyUnit)
    {
        dmgDealt = (Dmg.GetNumber() + weatherModifier + strModifier);
        int HitChance = chanceDice.GetNumber();
        if (HitChance >= 6)
        {
            if (HitChance >= 12)
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
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(" Succesful Hit!");
                Console.WriteLine();
                EnemyUnit.Defend(this);
            }
        }
        else if (HitChance <= 1)
        {
            Console.WriteLine(" Epic Fail!");
            HP -= 1;
        }
        else { Console.WriteLine(" Swing and Miss!"); }
    }
    public override void Defend(Unit EnemyUnit)
    {

        int HitChance = chanceDice.GetNumber();
        if (HitChance > 8)
        {
            Console.WriteLine(" Great Defense!");
            HP -= ((EnemyUnit.dmgDealt / 2) - armModifier);
        }
        else if (HitChance >= 12)
        {
            Console.WriteLine(" Epic Defense");
        }
        else if (HitChance <= 1)
        {
            Console.WriteLine(" Horrible Defense!");
            HP -= (EnemyUnit.dmgDealt + 2 - armModifier);
        }
        else
        {
            Console.WriteLine(" Block Failed!");
            HP -= (EnemyUnit.dmgDealt - armModifier);
        }
    }
}
sealed class MeleeHuman : Melee
{
    public MeleeHuman()
    {
        GiveName();
        Racist = Race.Human;
        hp = 100;
        maxHp = hp;
        res = 7;
        caca = 21;
        STR = 8;
        ARM = 8;
    }
}
sealed class MeleeVamp : Melee
{
    public MeleeVamp()
    {
        GiveName();
        Racist = Race.Vampire;
        hp = 90;
        maxHp = hp;
        res = 5;
        caca = 15;
        STR = 12;
        ARM = 4;
    }
}
sealed class MeleeWolf : Melee
{
    public MeleeWolf()
    {
        GiveName();
        Racist = Race.Werewolf;
        hp = 115;
        maxHp = hp;
        res = 5;
        caca = 15;
        STR = 10;
        ARM = 7;
    }
}