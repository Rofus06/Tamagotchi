using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tamagotchi!");
        Console.WriteLine("Please choose a name for your Tamagotchi!");

        // Skapa Tamagotchin
        string name = Console.ReadLine();
        Tamagotchi myTama = new Tamagotchi(name);

        while (myTama.GetAlive())
        {
            Console.Clear();
            myTama.PrintStats();

            // Spelval för dagen
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Do nothing");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                myTama.Feed();
            }
            else
            {
                Console.WriteLine("Doing nothing...");
            }

            myTama.Tick();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        Console.WriteLine($"OH NO! {myTama.Name} is dead!");
        Console.WriteLine("Press ENTER to quit.");
        Console.ReadLine();
    }
}
