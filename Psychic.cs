﻿//      _____                      _    __                                 
//     /  __ \ |                  | |  / _|                                
//     | /  \/ | ___  ___  ___  __| | | |_ ___  _ __   _ __   _____      __
//     | |   | |/ _ \/ __|/ _ \/ _` | |  _/ _ \| '__| | '_ \ / _ \ \ /\ / /
//     | \__/\ | (_) \__ \  __/ (_| | | || (_) | |    | | | | (_) \ V V  / 
//      \____/_|\___/|___/\___|\__,_| |_| \___/|_|    |_| |_|\___/ \_/\_/  

//abstract class Psychic : Unit
//{
//    //Intelligence
//    public virtual int INT { get; protected set; }
//    //Insight
//    protected virtual int INS { get; set; }
//    public override void Attack(Unit EnemyUnit)
//    {
//        int HitChance = ChanceDice.GetNumber();
//        if (HitChance >= 6)
//        {
//            Console.WriteLine("Succesful Hit!");
//            EnemyUnit.Defend(this);
//            if (HitChance >= 12)
//            {
//                Console.WriteLine("Critical Hit!");
//                EnemyUnit.Defend(this);
//                EnemyUnit.Defend(this);
//            }
//        }
//        else if (HitChance <= 1)
//        {
//            Console.WriteLine("Epic Fail!");
//            HP -= 1;
//        }
//        else { Console.WriteLine("Swing and Miss!"); }
//    }
//    public override void Defend(Unit EnemyUnit)
//    {
//        int HitChance = ChanceDice.GetNumber();
//        if (HitChance > 8)
//        {
//            Console.WriteLine("Block Failed!");
//            HP -= EnemyUnit.DmgDice.GetNumber();
//        }
//        else if (HitChance >= 12)
//        {
//            Console.WriteLine("Epic Defense");
//        }
//        else if (HitChance <= 1)
//        {
//            Console.WriteLine("Horrible Defense!");
//            HP -= (EnemyUnit.DmgDice.GetNumber() + 2);
//        }
//        else
//        {
//            Console.WriteLine("Great Defense!");
//            HP -= (EnemyUnit.DmgDice.GetNumber() / 2);
//        }
//    }
//}

//sealed class PsyHuman : Psychic
//{
//    protected override void SetStats()
//    {
//        Racist = Race.Human;
//        base.SetStats();
//        INT = 13;
//        INS = 9;
//    }
//}
//sealed class PsyVamp : Psychic
//{
//    protected override void SetStats()
//    {
//        Racist = Race.Vampire;
//        base.SetStats();
//        INS = 14;
//        INT = 12;
//    }
//}
//sealed class PsyWolf : Psychic
//{
//    protected override void SetStats()
//    {
//        Racist = Race.Werewolf;
//        base.SetStats();
//        INT = 8;
//        INS = 13;
//    }
//}