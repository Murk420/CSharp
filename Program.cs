using System.Drawing;

namespace HW._1
{
    public class Program
    {
        static void Main()
        {
            //For easier reading
            void Space() { Console.WriteLine(); }
            List<Unit> GoodUnits = new();
            List<Unit> BadUnits = new();
            //Method for creating an Army of Units
            void UnitRecruit(int Amount, List<Unit> list)
            {
                for (int i = 0; i < Amount; i++)
                {
                    int RandomUnit = Random.Shared.Next(0, 8);
                    switch (RandomUnit)
                    {
                        case 0:
                            MeleeHuman meleeHuman = new();
                            list.Add(meleeHuman);
                            break;
                        case 1:
                            MeleeVamp meleeVamp = new();
                            list.Add(meleeVamp);
                            break;
                        case 2:
                            MeleeWolf meleeWolf = new();
                            list.Add(meleeWolf);
                            break;
                        case 3:
                            RangedHuman rangedHuman = new();
                            list.Add(rangedHuman);
                            break;
                        case 4:
                            RangedVamp rangedVamp = new();
                            list.Add(rangedVamp);
                            break;
                        case 5:
                            RangedWolf rangedWolf = new();
                            list.Add(rangedWolf);
                            break;
                        case 6:
                            PsyHuman psyHuman = new();
                            list.Add(psyHuman);
                            break;
                        case 7:
                            PsyVamp psyVamp = new();
                            list.Add(psyVamp);
                            break;
                        case 8:
                            PsyWolf psyWolf = new();
                            list.Add(psyWolf);
                            break;
                    }
                }
            }
            UnitRecruit(5, GoodUnits);
            UnitRecruit(5, BadUnits);
            int GoodLoot = 0;
            int BadLoot = 0;
            Console.WriteLine("The Battle is soon to begin!");
            int order = 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;          
            Console.WriteLine("The Good Team :D :");
            foreach (Unit unit in GoodUnits)
            {
                order++;
                Console.WriteLine(order + ". " + unit);
                GoodLoot += unit.Res;
            }
            Console.WriteLine("Team Resources: " + GoodLoot);
            Space();
            order = 0;
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("The Bad Team >:( :");
            foreach (Unit unit in BadUnits)
            {
                order++;
                Console.WriteLine(order + ". " + unit);
                BadLoot += unit.Res;
            }
            Console.WriteLine("Team Resources: " + BadLoot);
            Console.ResetColor();
            Space();
            GoodLoot = 0;
            BadLoot = 0;
            int Round = 0;
            Weather CurrentWeather = Weather.Nice;

            //Method for Weather change
            void ChangeWeather()
            {
                int weather = Random.Shared.Next(0, 4);
                var w = (Weather)weather;
                switch (weather)
                {
                    case 0:
                        CurrentWeather = Weather.Heatwave;
                        Console.WriteLine("The Gods of the sun are angry, Better stay Hydrated!");
                        break;
                    case 1:
                        CurrentWeather = Weather.Warm;
                        Console.WriteLine("It's getting hot in here, Hope you brought Sunscreen!");
                        break;
                    case 2:
                        CurrentWeather = Weather.Nice;
                        Console.WriteLine("Nice weather outside, Enjoy it while it lasts!");
                        break;
                    case 3:
                        CurrentWeather = Weather.Heatwave;
                        Console.WriteLine("Shivers run down your spine, Hope you brought a Jacket!");
                        break;
                    case 4:
                        CurrentWeather = Weather.Heatwave;
                        Console.WriteLine("Winter is Coming, Better light a Bonfire!");
                        break;
                    default:
                        break;
                }
            }
            int WeatherDuration = Random.Shared.Next(1, 5);
            Console.WriteLine(  "Press any key to start");
            Console.ReadKey();
            Console.WriteLine("Fight!");

            //Battle Sequence
            while (GoodUnits.Count > 0 && BadUnits.Count > 0)
            {
                Round++;
                Console.WriteLine("Round: " + Round);
                //Chance for Weather to Change For a random duration
                if (Round == WeatherDuration)
                {
                    WeatherDuration = Random.Shared.Next(Round + 1, Round + 6);
                    int forecast = Random.Shared.Next(1, 5);
                    if (forecast > 2)
                    {
                        ChangeWeather();
                        foreach (Unit goodunit in GoodUnits)
                        {
                            goodunit.WeatherEffect(CurrentWeather, goodunit.Racist);
                        }
                        foreach (Unit badunit in BadUnits)
                        {
                            badunit.WeatherEffect(CurrentWeather, badunit.Racist);
                        }
                    }
                }
                Console.WriteLine("Good Units Alive:" + GoodUnits.Count);
                Console.WriteLine("Bad Units Alive:" + BadUnits.Count);
                Space();
                //Good Units Attacking
                int ATK1 = Random.Shared.Next(0, GoodUnits.Count);
                int DEF1 = Random.Shared.Next(0, BadUnits.Count);
                Console.WriteLine("Good " + GoodUnits[ATK1] + " Attacks Bad " + BadUnits[DEF1]);
                Space();
                GoodUnits[ATK1].Attack(BadUnits[DEF1]);
                //Removing Dead Units from lists
                if (BadUnits[DEF1].isdead)
                {
                    Console.WriteLine(BadUnits[DEF1] + " Has Died!");
                    GoodUnits[ATK1].Loot(BadUnits[DEF1]);
                    GoodLoot += BadUnits[DEF1].ResLooted;
                    BadUnits.Remove(BadUnits[DEF1]);
                }
                if (GoodUnits[ATK1].isdead)
                {
                    Console.WriteLine(GoodUnits[ATK1] + " Has Died!");
                    BadUnits[DEF1].Loot(GoodUnits[ATK1]);
                    BadLoot += GoodUnits[ATK1].ResLooted;
                    GoodUnits.Remove(GoodUnits[ATK1]);
                }
                if (GoodUnits.Count == 0 || BadUnits.Count == 0)
                {
                    break;
                }
                Space();
                //Bad Units Attacking
                int ATK2 = Random.Shared.Next(0, BadUnits.Count);
                int DEF2 = Random.Shared.Next(0, GoodUnits.Count);
                Console.WriteLine("Bad " + BadUnits[ATK2] + " Attacks Good " + GoodUnits[DEF2]);
                BadUnits[ATK2].Attack(GoodUnits[DEF2]);
                //Removing Bodies yet again
                if (GoodUnits[DEF2].isdead)
                {
                    Console.WriteLine(GoodUnits[DEF2] + " Has Died!");
                    BadUnits[ATK2].Loot(GoodUnits[DEF2]);
                    BadLoot += GoodUnits[DEF2].ResLooted;
                    GoodUnits.Remove(GoodUnits[DEF2]);
                }
                if (BadUnits[ATK2].isdead)
                {
                    Console.WriteLine(BadUnits[ATK2] + " Has Died!");
                    GoodUnits[DEF2].Loot(BadUnits[ATK2]);
                    GoodLoot += BadUnits[ATK2].ResLooted;
                    BadUnits.Remove(BadUnits[ATK2]);
                }
                Console.WriteLine();

            }

            Space();
            Console.WriteLine("The Battle Is Over!");
            Space();
            
            //Bad Ending
            if (GoodUnits.Count == 0)
            {
                Console.WriteLine("The Baddies Won :(");
                foreach (Unit unit in BadUnits)
                {
                    Console.WriteLine(unit + " HP: " + unit.HP);
                }
                Console.WriteLine("Resources Looted: " + BadLoot);
            }

            //Good Ending
            if (BadUnits.Count == 0)
            {
                Console.WriteLine("The Good Guys Won :)");
                foreach (Unit unit in GoodUnits)
                {
                    Console.WriteLine(unit + " HP: " + unit.HP);
                }
                Console.WriteLine("Resources Looted: " + GoodLoot);
            }
        }
    }
}