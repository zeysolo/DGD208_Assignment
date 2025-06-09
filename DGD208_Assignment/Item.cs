/*using System;

namespace DGD208_Assignment
{
    public enum ItemType
    {
        Food,
        Toy,
        Talking
    }

    internal class Item
    {
        public string Name { get; }
        public ItemType Type { get; }
        public int Value { get; }

        public Item(string name, ItemType type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}, +{Value})";
        }
    }
}
*/

namespace DGD208_Assignment
{
    public enum ItemType
    {
        Food,
        Toy,
        Talking
    }

    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public PetStat AffectedStat { get; set; }
        public int EffectAmount { get; set; }

        public int Duration { get; set; } = 0; // Default duration is 0, meaning no time limit

        public Item(string name, ItemType type, PetStat stat, int amount, int duration)
        {
            Name = name;
            Type = type;
            AffectedStat = stat;
            EffectAmount = amount;
            Duration = duration;
        }
    }
}
