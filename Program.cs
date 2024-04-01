

namespace HW._1
{
    public class Program
    {
        static void Main()
        {
            RandomFighter bruh = new();
            bruh.Fight();
            ////For easier reading
            //void Space() { Console.WriteLine(); }
            //List<Unit> GoodUnits = new();
            //List<Unit> BadUnits = new();
            ////Method for creating an Army of Units
            //void UnitRecruit(int Amount, List<Unit> list)
            //{
            //    for (int i = 0; i < Amount; i++)
            //    {
            //        int RandomUnit = Random.Shared.Next(0, 6);
            //        switch (RandomUnit)
            //        {
            //            case 0:
            //                MeleeHuman meleeHuman = new();
            //                list.Add(meleeHuman);
            //                break;
            //            case 1:
            //                MeleeVamp meleeVamp = new();
            //                list.Add(meleeVamp);
            //                break;
            //            case 2:
            //                MeleeWolf meleeWolf = new();
            //                list.Add(meleeWolf);
            //                break;
            //            case 3:
            //                RangedHuman rangedHuman = new();
            //                list.Add(rangedHuman);
            //                break;
            //            case 4:
            //                RangedVamp rangedVamp = new();
            //                list.Add(rangedVamp);
            //                break;
            //            case 5:
            //                RangedWolf rangedWolf = new();
            //                list.Add(rangedWolf);
            //                break;
            //        }
            //    }
            //}
            //UnitRecruit(5, GoodUnits);
            //UnitRecruit(5, BadUnits);
            //int goodResources = 0;
            //int badResources = 0;
            //Console.WriteLine(" The Battle is soon to begin!");
            //Space();
            //int order = 0;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(" The Good Team :D");
            //Space();
            //foreach (Unit unit in GoodUnits)
            //{
            //    order++;
            //    Console.WriteLine($" {order}. {unit} {unit.Name} - HP: {unit.HP}");
            //    goodResources += unit.Res;
            //    Space();
            //}
            //Console.WriteLine($" Team Resources: {goodResources}");
            //Space();
            //order = 0;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(" The Bad Team >:( ");
            //Space();
            //foreach (Unit unit in BadUnits)
            //{
            //    order++;
            //    Console.WriteLine($" {order}. {unit} {unit.Name} - HP: {unit.HP}");
            //    badResources += unit.Res;
            //    Space();
            //}
            //Console.WriteLine($" Team Resources: {goodResources}");
            //Console.ResetColor();
            //Space();
            //int Round = 0;
            //Weather CurrentWeather = Weather.Nice;

            ////Method for Weather change
            //void ChangeWeather()
            //{
            //    int weather = Random.Shared.Next(0, 4);
            //    switch (weather)
            //    {
            //        case 0:
            //            CurrentWeather = Weather.Heatwave;
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //            Console.WriteLine(" The Gods of the sun are angry, Better stay Hydrated!");
            //            Console.ResetColor();
            //            break;
            //        case 1:
            //            CurrentWeather = Weather.Warm;
            //            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //            Console.WriteLine(" It's getting hot in here, Hope you brought Sunscreen!");
            //            Console.ResetColor();
            //            break;
            //        case 2:
            //            CurrentWeather = Weather.Cold;
            //            Console.ForegroundColor = ConsoleColor.Cyan;
            //            Console.WriteLine(" Shivers run down your spine, Hope you brought a Jacket!");
            //            Console.ResetColor();
            //            break;
            //        case 3:
            //            CurrentWeather = Weather.Freezing;
            //            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //            Console.WriteLine(" Winter is Coming, Better light a Bonfire!");
            //            Console.ResetColor();
            //            break;
            //    }
            //}
            //int WeatherDuration = Random.Shared.Next(1, 5);
            //Console.WriteLine(" Press any key to start");
            //Console.ReadKey();

            ////Battle Sequence
            //while (GoodUnits.Count > 0 && BadUnits.Count > 0)
            //{
            //    Console.WriteLine("------------------------- Round:  " + Round + " ------------------------- ");
            //    Console.WriteLine(" Fight!");
            //    Space();
            //    Round++;
            //    //Chance for Weather to Change For a random duration
            //    if (Round == WeatherDuration)
            //    {
            //        //Chance of Weather Change
            //        int forecast = Random.Shared.Next(1, 5);
            //        //Duration of Weather Change
            //        WeatherDuration = Random.Shared.Next(Round + 1, Round + 6);
            //        if (forecast > 2)
            //        {
            //            ChangeWeather();
            //            Space();
            //        }
            //        else
            //        {
            //            CurrentWeather = Weather.Nice;
            //            Console.ForegroundColor = ConsoleColor.Yellow;                       
            //            Console.WriteLine(" Nice weather outside, Enjoy it while it lasts!");
            //            Space();    
            //            Console.ResetColor();
            //        }
            //        foreach (Unit goodunit in GoodUnits)
            //        {
            //            goodunit.WeatherEffect(CurrentWeather, goodunit.Racist);
            //        }
            //        foreach (Unit badunit in BadUnits)
            //        {
            //            badunit.WeatherEffect(CurrentWeather, badunit.Racist);
            //        }
            //    }

            //    //Good Unit Attacking
            //    int ATK1 = Random.Shared.Next(0, GoodUnits.Count);
            //    //Target
            //    int DEF1 = Random.Shared.Next(0, BadUnits.Count);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.Write($" {GoodUnits[ATK1]} {GoodUnits[ATK1].Name}");
            //    Console.ResetColor();
            //    Console.Write(" Attacks");
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($" {BadUnits[DEF1]} {BadUnits[DEF1].Name}");
            //    Console.ResetColor();
            //    Space();
            //    GoodUnits[ATK1].Attack(BadUnits[DEF1]);
            //    Space();

            //    //Removing Dead Units from lists
            //    if (BadUnits[DEF1].isdead)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write($" {BadUnits[DEF1]} {BadUnits[DEF1].Name}");
            //        Console.ResetColor();
            //        Console.WriteLine(" Has Died!"); 
            //        Space();
            //        GoodUnits[ATK1].Loot(BadUnits[DEF1]);
            //        BadUnits.Remove(BadUnits[DEF1]);
            //    }
            //    if (GoodUnits[ATK1].isdead)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write($" {GoodUnits[ATK1]} {GoodUnits[ATK1].Name}");
            //        Console.ResetColor();
            //        Console.WriteLine(" Has Died!"); 
            //        Space();
            //        BadUnits[DEF1].Loot(GoodUnits[ATK1]);
            //        GoodUnits.Remove(GoodUnits[ATK1]);
            //    }
            //    if (GoodUnits.Count == 0 || BadUnits.Count == 0)
            //    {
            //        break;
            //    }

            //    //Bad Unit Attacking
            //    int ATK2 = Random.Shared.Next(0, BadUnits.Count);
            //    //Target
            //    int DEF2 = Random.Shared.Next(0, GoodUnits.Count);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write($" {BadUnits[ATK2]} {BadUnits[ATK2].Name}");
            //    Console.ResetColor();
            //    Console.Write(" Attacks");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($" {GoodUnits[DEF2]} {GoodUnits[DEF2].Name}");
            //    Console.ResetColor();
            //    Space();
            //    BadUnits[ATK2].Attack(GoodUnits[DEF2]);
            //    Space();

            //    //Removing Bodies yet again
            //    if (GoodUnits[DEF2].isdead)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write($" {GoodUnits[DEF2]} {GoodUnits[DEF2].Name}");
            //        Console.ResetColor();
            //        Console.WriteLine(" Has Died!");
            //        Space();
            //        BadUnits[ATK2].Loot(GoodUnits[DEF2]);
            //        GoodUnits.Remove(GoodUnits[DEF2]);
            //    }
            //    if (BadUnits[ATK2].isdead)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write($" {BadUnits[ATK2]} {BadUnits[ATK2].Name}");
            //        Console.ResetColor();                    
            //        Console.WriteLine(" Has Died!");
            //        Space();
            //        GoodUnits[DEF2].Loot(BadUnits[ATK2]);
            //        BadUnits.Remove(BadUnits[ATK2]);
            //    }

            //    //Round summary
            //    Console.WriteLine(" Round Over!");
            //    Space();
            //    Console.WriteLine($" Good Units Alive: {GoodUnits.Count}");
            //    Space();
            //    Console.WriteLine($" Bad Units Alive: {BadUnits.Count}");
            //    Space();
            //}

            ////End of Battle
            //Console.WriteLine("---------------------------------------------------------------");
            //Space();
            //Console.WriteLine(" The Battle Is Over!");
            //Space();

            ////Good Ending
            //if (BadUnits.Count == 0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    int Loot = 0;
            //    Console.WriteLine(" The Good Guys Won :) ");
            //    Space();
            //    foreach (Unit unit in GoodUnits)
            //    {
            //        Console.WriteLine($" {unit} {unit.Name} - HP: {unit.HP}");
            //        Space();
            //        Loot += unit.Res;
            //    }
            //    Space();
            //    Console.WriteLine($" Resources Looted: {Loot - goodResources}");
            //}

            ////Bad Ending
            //if (GoodUnits.Count == 0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    int Loot = 0;
            //    Console.WriteLine(" The Baddies Won :( ");
            //    Space();
            //    foreach (Unit unit in BadUnits)
            //    {
            //        Console.WriteLine($" {unit} {unit.Name} - HP: {unit.HP}");
            //        Space();
            //        Loot += unit.Res;
            //    }                
            //    Console.WriteLine($" Resources Looted: {Loot - badResources}");
            //}

        }
    }
}