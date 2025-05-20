using System;
using System.Collections.Generic;
using DGD208_Assignment;

public class Menu<T>
{
    private readonly List<T> _items;
    private readonly string _title;
    private readonly Func<T, string> _displaySelector;

    public Menu(string title, List<T> items, Func<T, string> displaySelector = null)
    {
        _title = title;
        _items = items ?? new List<T>();
        _displaySelector = displaySelector ?? (item => item?.ToString() ?? "");
    }

    public T ShowAndGetSelection()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine($"No items available in {_title}. Press any key to continue...");
            Console.ReadKey();
            return default(T);
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== {_title} ===");
            Console.WriteLine();

            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_displaySelector(_items[i])}");
            }

            Console.WriteLine();
            Console.WriteLine("0. Go Back");
            Console.WriteLine();
            Console.Write("Enter selection: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int selection))
            {
                if (selection == 0)
                    return default(T);

                if (selection > 0 && selection <= _items.Count)
                    return _items[selection - 1];
            }

            Console.WriteLine("Invalid selection. Press any key to try again.");
            Console.ReadKey();







/*
            List<Creature> pets = new List<Creature>
        {
            new Creature(PetType.Resa),
            new Creature(PetType.Leza),
            new Creature(PetType.Mona),
            new Creature(PetType.Luxa),
            new Creature(PetType.Ophex)
        };

            // Create the menu
            Menu<Creature> petMenu = new Menu<Creature>(
                "Select a pet to adopt",
                pets,
                pet => pet.Name.ToString()  // Display pet's name
            );

            // Show menu and get user selection
            Creature selectedPet = petMenu.ShowAndGetSelection();

            if (selectedPet != null)
            {
                Console.WriteLine($"You adopted: {selectedPet.Name}!");
            }
            else
            {
                Console.WriteLine("No pet selected.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); */
        }
    }
}
