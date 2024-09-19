using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tamagotchi!");
        Console.WriteLine("Please choose a name for your Tamagotchi!"); //Vad som kommer stå i början

        // Skapa Tamagotchin
        string name = Console.ReadLine();
        Tamagotchi myTama = new Tamagotchi(name);

        while (myTama.GetAlive())
        {
            Console.Clear();
            myTama.PrintStats();

            // Spelval
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Talk to your Tamagotchi");
            Console.WriteLine("3. Teach a new word");
            Console.WriteLine("4. Do nothing");

            string choice = Console.ReadLine();

            if (choice == "1") //Om man trycker på 1 och enter kommer man feeda Tamagotchi
            {
                myTama.Feed();
            }
            else if (choice == "2")// trycker på 2 och enter kommer man prata med Tamagotchi
            {
                myTama.Hi();
            }
            else if (choice == "3") // trycker på 3 och enter kommer man lära Tamagotchi ett ord
            {
                Console.WriteLine("What word would you like to teach?");
                string word = Console.ReadLine();
                myTama.Teach(word);
            }
            else
            {
                Console.WriteLine("Doing nothing..."); //...do nothing...
            }

            myTama.Tick();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        Console.WriteLine($"OH NO! {myTama.Name} is dead!"); //om "Hunger" eller "boredom" är 10 så dör Tamagotchi
        Console.WriteLine("Press ENTER to quit.");
        Console.ReadLine();
    }
}
