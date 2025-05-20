/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Assignment
{
    internal class myLittleTamagotchi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//meet with your pathfinder.");
            Console.WriteLine(@"
 █     █░ ▒█████   ███▄    █ ▓█████▄ ▓█████  ██▀███   ██▓    ▄▄▄       ███▄    █ ▓█████▄ 
▓█░ █ ░█░▒██▒  ██▒ ██ ▀█   █ ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒▓██▒   ▒████▄     ██ ▀█   █ ▒██▀ ██▌
▒█░ █ ░█ ▒██░  ██▒▓██  ▀█ ██▒░██   █▌▒███   ▓██ ░▄█ ▒▒██░   ▒██  ▀█▄  ▓██  ▀█ ██▒░██   █▌
░█░ █ ░█ ▒██   ██░▓██▒  ▐▌██▒░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄  ▒██░   ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█▄   ▌
░░██▒██▓ ░ ████▓▒░▒██░   ▓██░░▒████▓ ░▒████▒░██▓ ▒██▒░██████▒▓█   ▓██▒▒██░   ▓██░░▒████▓ 
░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░░ ▒░▓  ░▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▒▓  ▒ 
  ▒ ░ ░    ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░░ ░ ▒  ░ ▒   ▒▒ ░░ ░░   ░ ▒░ ░ ▒  ▒ 
  ░   ░  ░ ░ ░ ▒     ░   ░ ░  ░ ░  ░    ░     ░░   ░   ░ ░    ░   ▒      ░   ░ ░  ░ ░  ░ 
    ░        ░ ░           ░    ░       ░  ░   ░         ░  ░     ░  ░         ░    ░    
                              ░                                                   ░");

            //pets vixen = new pets();
            pets resa = new pets();
            pets leza = new pets();

            resa.Name = "Resa";
            resa.Species = "the cunning vixen";
            resa.Figure = @"
      |\__/|
     /     \
    /_.~ ~,_\
       \@/
";

            leza.Name = "Leza";
            leza.Species = "the luna moth";
            leza.Figure = @" 
      __ \/ __
     /o \{}/ o\
     \   ()   /
      `> /\ <`
      (o/\/\o)
       )    (
";

            resa.Meeting();
            leza.Meeting();

            //Console.WriteLine("now you can see me.");
            //Console.WriteLine($"the cards gave me the name {Name}.");
            Console.Read(); 




        }
    }
}
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Assignment
{
    class myLittleTamagotchi
    {
        static void Main(string[] args)
        {



            List<Creature> adoptedPets = new List<Creature>();
            List<Item> availableItems = new List<Item>
            {
                new Item("Blue Milk", ItemType.Food, PetStat.Hunger, 10),
                new Item("Hunting", ItemType.Toy, PetStat.Fun, 10),
                new Item("Storytelling", ItemType.Talking, PetStat.Sleep, 10)
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("//meet with your pathfinder.");
                Console.WriteLine(@"
 █     █░ ▒█████   ███▄    █ ▓█████▄ ▓█████  ██▀███   ██▓    ▄▄▄       ███▄    █ ▓█████▄ 
▓█░ █ ░█░▒██▒  ██▒ ██ ▀█   █ ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒▓██▒   ▒████▄     ██ ▀█   █ ▒██▀ ██▌
▒█░ █ ░█ ▒██░  ██▒▓██  ▀█ ██▒░██   █▌▒███   ▓██ ░▄█ ▒▒██░   ▒██  ▀█▄  ▓██  ▀█ ██▒░██   █▌
░█░ █ ░█ ▒██   ██░▓██▒  ▐▌██▒░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄  ▒██░   ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█▄   ▌
░░██▒██▓ ░ ████▓▒░▒██░   ▓██░░▒████▓ ░▒████▒░██▓ ▒██▒░██████▒▓█   ▓██▒▒██░   ▓██░░▒████▓ 
░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░░ ▒░▓  ░▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▒▓  ▒ 
  ▒ ░ ░    ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░░ ░ ▒  ░ ▒   ▒▒ ░░ ░░   ░ ▒░ ░ ▒  ▒ 
  ░   ░  ░ ░ ░ ▒     ░   ░ ░  ░ ░  ░    ░     ░░   ░   ░ ░    ░   ▒      ░   ░ ░  ░ ░  ░ 
    ░        ░ ░           ░    ░       ░  ░   ░         ░  ░     ░  ░         ░    ░    
                              ░                                                   ░");


                Console.WriteLine("1. We have some candy for you inside.");
                Console.WriteLine("2. View creature stats");
                Console.WriteLine("3. Use an item on a creature");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Which creature would you like to meet?");
                        foreach (PetType type in Enum.GetValues(typeof(PetType)))
                        {
                            if (!adoptedPets.Exists(p => p.Name == type))
                                Console.WriteLine($"{(int)type} - {type}");
                        }
                        Console.Write("Enter number: ");
                        int adoptChoice;
                        if (int.TryParse(Console.ReadLine(), out adoptChoice))
                        {
                            if (!adoptedPets.Exists(p => p.Name == (PetType)adoptChoice))
                                adoptedPets.Add(new Creature((PetType)adoptChoice));

                        }
                        break;

                    case "2":
                        foreach (var pet in adoptedPets)
                            pet.DisplayStats();
                        Console.ReadKey();
                        break;

                    case "3":
                        if (adoptedPets.Count == 0)
                        {
                            Console.WriteLine("You haven't meet with anyone yet.");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Choose a creature:");
                        for (int i = 0; i < adoptedPets.Count; i++)
                            Console.WriteLine($"{i + 1}. {adoptedPets[i].Name}");
                        int petChoice = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("Choose an item:");
                        for (int i = 0; i < availableItems.Count; i++)
                            Console.WriteLine($"{i + 1}. {availableItems[i].Name}");
                        int itemChoice = int.Parse(Console.ReadLine()) - 1;

                        adoptedPets[petChoice].UseItem(availableItems[itemChoice]);
                        break;

                    case "0":
                        return;
                }




            }
        }
    }
}
