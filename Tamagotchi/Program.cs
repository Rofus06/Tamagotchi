using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tamagotchi!");

        // Lista för att hålla flera Tamagotchis
        List<Tamagotchi> tamagotchis = new List<Tamagotchi>();

        // Loop för att skapa Tamagotchis
        while (true)
        {
            Console.WriteLine("Do you want to create a new Tamagotchi? (y/n)");
            string createNew = Console.ReadLine(); // new Tamagotchi man får välja om man vill ha
            if (createNew.ToLower() != "y") break;

            Console.WriteLine("Please choose a name for your Tamagotchi!");
            string name = Console.ReadLine();
            tamagotchis.Add(new Tamagotchi(name));  // Lägg till ny Tamagotchi i listan
        }

        var startTime = DateTime.Now; //timer för hur länge du levde (demo) fick såg det här: https://stackoverflow.com/questions/68593505/trying-to-set-a-datetime-start-time-based-off-datetime-now

        // loop för att hantera Flera Tamagotchis om man vill ha det
        while (tamagotchis.Count > 0)
        {
            foreach (var myTama in tamagotchis.ToArray())  // Loop genom alla Tamagotchis
            {
                if (myTama.GetAlive())
                {
                    Console.Clear();
                    myTama.PrintStats();

                    // Val för varje Tamagotchi
                    Console.WriteLine($"What do you want to do with {myTama.Name}?");
                    Console.WriteLine("1. Feed"); // Feed om trycker 1 och enter
                    Console.WriteLine("2. Talk to your Tamagotchi"); // Talk med Tamagotchi om man trycker 2 och enter
                    Console.WriteLine("3. Teach a new word"); // Teach Tamagotchi om man trycker 3 och enter
                    Console.WriteLine("4. Do nothing"); //...Do nothing...

                    string choice = Console.ReadLine();

                    if (choice == "1") // 1 selected kommer Feed coden (public void Feed) bli activerad
                        myTama.Feed();
                    else if (choice == "2") // samma som Feed 
                        myTama.Talk();
                    else if (choice == "3") // om 3 kommer man kunna skriva ett ord den ska lära sig
                    {
                        Console.WriteLine("What word would you like to teach?");
                        string word = Console.ReadLine();
                        myTama.Teach(word);
                    }
                    else 
                        Console.WriteLine("Doing nothing..."); //om man trycker enter uttan att trycka på ett numer så blir det "do nothing"

                    myTama.Tick();
                    Console.WriteLine("Press Enter to continue."); // efter du valt kommer det här up ez
                    Console.ReadLine();
                }
                else
                {
                    tamagotchis.Remove(myTama);  // Tar bort den döda Tamagotchis
                    Console.ForegroundColor = ConsoleColor.Red;  // Ändra färgen till röd (fick hjälp på internet för att veta hur man ändrar färgen)
                    Console.WriteLine($"OH NO! {myTama.Name} is dead!"); // vissar vem är död 
                    Console.ResetColor();  // Återställ färgen till "standard"
                    Console.ReadLine(); // ReadLine så man kan see vem som dog att den är död
                }
            }
        }
        var endTime = DateTime.Now; // End timer för hur länge du levde (demo) såg det ifrån det här: https://stackoverflow.com/questions/68593505/trying-to-set-a-datetime-start-time-based-off-datetime-now
        var survivalTime = endTime - startTime; //survivalTime för att kunna vissa hur länga jag levde för personen
        Console.WriteLine("All your Tamagotchis are dead! Game over.");
        Console.WriteLine($"You survived for {survivalTime.TotalSeconds} Seconds."); //hur länge du överlevde
        Console.ReadLine(); // ReadLine så man kan see "Console.WriteLine("All your Tamagotchis are dead! Game over.");"
    }
}