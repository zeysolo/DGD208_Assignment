using System;
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
