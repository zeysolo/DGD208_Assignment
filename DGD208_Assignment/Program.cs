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

using System.Threading;

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

            ascii art =new ascii(); 

            List<Creature> adoptedPets = new List<Creature>();
            List<Item> availableItems = new List<Item>
            {
                new Item("Blue Milk", ItemType.Food, PetStat.Hunger, 10,3000),
                new Item("Lembas Bread", ItemType.Food, PetStat.Hunger, 10,3000),
                new Item("Pan Galactic Gargle Blaster", ItemType.Food, PetStat.Hunger, 10,3000),

                new Item("Minotaur Maze", ItemType.Toy, PetStat.Fun, 10,3000),
                new Item("Chessboard of Fate", ItemType.Toy, PetStat.Fun, 10,3000),
                new Item("Golden Snitch", ItemType.Toy, PetStat.Fun, 10,3000),

                new Item("Lotus Whisper", ItemType.Talking, PetStat.Sleep, 10,3000),
                new Item("Scheherazade’s Tale", ItemType.Talking, PetStat.Sleep, 10,3000),
                new Item("Dreamcatcher", ItemType.Talking, PetStat.Sleep, 10,3000)

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



                Console.WriteLine("");
            
                Console.WriteLine("1. We have some candy for you inside.");
                Console.WriteLine("2. Look at them.");
                Console.WriteLine("3. Pamper them.");
                Console.WriteLine("4. Credits.");
                Console.WriteLine("0. Exit.");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();



                switch (choice)


                {
                    /*case "1":
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
                        break;*/



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
                            {
                                Creature newCreature = new Creature((PetType)adoptChoice);
                                adoptedPets.Add(newCreature);

                                // 👇 ADD THIS: Show info after choosing
                                Console.Clear();
                                Console.WriteLine("Say hi.");
                                newCreature.DisplayStats();
                                newCreature.ShowArt();

                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("You've already know.");
                                Console.ReadKey();
                            }
                        }
                        break;


                    case "2":
                        if (adoptedPets.Count == 0)
                        {
                            Console.WriteLine("You haven't met anyone yet.");
                        }
                        else
                        {
                            List<Creature> petsToRemove = new List<Creature>();

                            foreach (var pet in adoptedPets)
                            {
                                pet.DisplayStats();
                                pet.ShowArt();
                                Console.WriteLine(" ");

                                bool isDead = false;
                                foreach (var stat in pet.Stats)
                                {
                                    if (stat.Value < 35 && stat.Value > 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{pet.Name} is having a hard time with {stat.Key}. ({stat.Value})");
                                        Console.ResetColor();
                                    }
                                    if (stat.Value <= 0)
                                    {
                                        isDead = true;
                                    }
                                }

                                if (isDead)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{pet.Name} has died because one of its stats reached 0!");
                                    Console.ResetColor();
                                    petsToRemove.Add(pet);
                                }
                            }

                            foreach (var pet in petsToRemove)
                            {
                                adoptedPets.Remove(pet);
                            }
                        }

                        Console.WriteLine("\nPress any key to return to menu.");
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
                        adoptedPets[petChoice].UseItem(availableItems[itemChoice]);

                        // waiting for the item's duration
                        System.Threading.Thread.Sleep(availableItems[itemChoice].Duration); // its milisecond

                        break;



                    case "4":
                        Console.Clear();
                        Console.WriteLine("a game by Zeynep Belinay Koçaker.");
                        Console.WriteLine("subject numb-, ahem, her magic number is 225040046.");
                        Console.WriteLine("");

                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case "0":
                        return;
                }




            }
        }
    }
}
