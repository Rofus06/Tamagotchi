using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int hunger = 0; //startar med 0
    private int boredom = 0; //startar med 0
    private List<string> words = new List<string>() {"Hello thanks for talking with me."}; //Om 2 är "selected" då säger den "Hello thanks for talking with me."
    private bool isAlive = true; //Alive in the beginning
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

    public void Hi()
    {
        if (words.Count > 0)
        {
            int wordNum = new Random().Next(words.Count);
            Console.WriteLine($" [{Name}] says: {words[wordNum]}");
        }
        ReduceBoredom();
    }

    public void Teach(string word) //Teach Tamagotch ett ord du vill
    {
        words.Add(word);
        Console.WriteLine($" [{Name}] learned: {word}");
        ReduceBoredom();
    }

    private void ReduceBoredom() // om du t.ex pratar med Tamagotchi (ReduceBoredom)
    {
        boredom -= 2;
        if (boredom < 0) boredom = 0;
        Console.WriteLine($" [{Name}] is now less bored!");
    }
}
