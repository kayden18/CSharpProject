﻿using System;
public class Program
{
    public static Game myGame = new Game();
    public static void Main(string[] args)
    {
        Console.WriteLine("Please type in your name:");
        myGame.name = Console.ReadLine();
        Console.WriteLine("Your Player name is " + myGame.name);
        myGame.Start();
    }
}
