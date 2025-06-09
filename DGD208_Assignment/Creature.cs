/* using System;
using System.Timers;

namespace DGD208_Assignment
{
    public class Creature
    {
        private const int StatDecayInterval = 8000; // 8 seconds
        private const int StatMin = 0;
        private const int StatMax = 100;

        private Timer _statTimer;

        public PetType Type { get; }
        public int Hunger { get; private set; }
        public int Sleep { get; private set; }
        public int Fun { get; private set; }

        public Creature(PetType type)
        {
            Type = type;
            Hunger = 50;
            Sleep = 50;
            Fun = 50;

            _statTimer = new Timer(StatDecayInterval);
            _statTimer.Elapsed += (sender, e) => DecayStats();
            _statTimer.AutoReset = true;
            _statTimer.Start();
        }

        private void DecayStats()
        {
            Hunger = Math.Max(StatMin, Hunger - 1);
            Sleep = Math.Max(StatMin, Sleep - 1);
            Fun = Math.Max(StatMin, Fun - 1);
        }

        public void UseItem(Item item)
        {
            switch (item.Type)
            {
                case ItemType.Food:
                    IncreaseStat(PetStat.Hunger, item.Value);
                    break;
                case ItemType.Toy:
                    IncreaseStat(PetStat.Fun, item.Value);
                    DecreaseStat(PetStat.Sleep, item.Value); // toy makes pet tired
                    break;
                case ItemType.Talking:
                    IncreaseStat(PetStat.Fun, item.Value / 2); // maybe cheering it up
                    break;
            }
        }

        private void IncreaseStat(PetStat stat, int value)
        {
            switch (stat)
            {
                case PetStat.Hunger:
                    Hunger = Math.Min(StatMax, Hunger + value);
                    break;
                case PetStat.Sleep:
                    Sleep = Math.Min(StatMax, Sleep + value);
                    break;
                case PetStat.Fun:
                    Fun = Math.Min(StatMax, Fun + value);
                    break;
            }
        }

        private void DecreaseStat(PetStat stat, int value)
        {
            switch (stat)
            {
                case PetStat.Hunger:
                    Hunger = Math.Max(StatMin, Hunger - value);
                    break;
                case PetStat.Sleep:
                    Sleep = Math.Max(StatMin, Sleep - value);
                    break;
                case PetStat.Fun:
                    Fun = Math.Max(StatMin, Fun - value);
                    break;
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"{Type} - Hunger: {Hunger}, Sleep: {Sleep}, Fun: {Fun}");
        }
    }
}
*/

using System;
using System.Timers;
using System.Collections.Generic;

namespace DGD208_Assignment
{
    public class Creature
    {
        public PetType Name { get; set; }
        public Dictionary<PetStat, int> Stats { get; set; }
        public Timer decayTimer;



        public string GetAsciiArt()
        {
            switch (Name)
            {
                case PetType.Resa:
                    return @"
      |\__/|
     /     \
    /_.~ ~,_\
       \@/
";
                case PetType.Leza:
                    return @"
     (\_._/)
     ( o o )
      > ^ <
";
                case PetType.Mona:
                    return @"
     /\_/\ 
    ( o.o )
     > ^ <
";
                case PetType.Luxa:
                    return @"
      /\_/\
     ( o.o )
      > ^ <
";
                case PetType.Ophex:
                    return @"
      /\_/\  
    =( °w° )=
      )   (  
     (__ __)
";
                default:
                    return "No ASCII Art Available";
            }
        }




        public Creature(PetType name)
        {
            Name = name;
            Stats = new Dictionary<PetStat, int>
            {
                { PetStat.Hunger, 50 },
                { PetStat.Sleep, 50 },
                { PetStat.Fun, 50 }
            };

            decayTimer = new Timer(8000); // 8 seconds
            decayTimer.Elapsed += DecayStats;
            decayTimer.Start();
        }

        public void DecayStats(object sender, ElapsedEventArgs e)
        {
            foreach (var stat in new List<PetStat>(Stats.Keys))
            {
                Stats[stat] = Math.Max(0, Stats[stat] - 1);
            }
        }



        public void UseItem(Item item)
        {
            if (Stats.ContainsKey(item.AffectedStat))
            {
                Stats[item.AffectedStat] = Math.Min(100, Stats[item.AffectedStat] + item.EffectAmount);

                // Optional: Apply side effects
                if (item.Type == ItemType.Toy && Stats.ContainsKey(PetStat.Sleep))
                {
                    Stats[PetStat.Sleep] = Math.Max(0, Stats[PetStat.Sleep] - item.EffectAmount);
                }
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"-- {Name} Stats --");
            foreach (var stat in Stats)
            {
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }
        }

        public void ShowArt()
        {
            ascii art = new ascii();
            switch (Name)
            {
                case PetType.Resa:
                    art.ResaArt(); break;
                case PetType.Leza:
                    art.LezaArt(); break;
                case PetType.Mona:
                    art.MonaArt(); break;
                case PetType.Luxa:
                    art.LuxaArt(); break;
                case PetType.Ophex:
                    art.OphexArt(); break;
            }
        }



    }
}
