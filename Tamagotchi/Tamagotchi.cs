using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>() {"Hewwo"};
    private bool isAlive = true;
    public string Name { get; set; }

    // Konstruktor
    public Tamagotchi(string name)
    {
        Name = name;
    }

    // Metod för att mata Tamagotchin
    public void Feed()
    {
        hunger -= 2;
        if (hunger < 0) hunger = 0;
        Console.WriteLine($" [{Name}] eats and becomes less hungry.");
    }

    // Tick() ökar hunger och boredom
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    // Metod för att skriva ut status
    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name} || Hunger: {hunger} || Boredom: {boredom}");
    }

    // Metod för att kolla om Tamagotchin lever
    public bool GetAlive()
    {
        return isAlive;
    }
}
