using System;
public class LevelBase
{
    public string StartMessage;
    public bool entranceOpen = true;
    public string[] environment;
    public string[] objects;
    public void Enter()
    {
        Console.WriteLine(StartMessage);
    }
    public void Encounter(int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You've walked into " + objects[i]);
                break;

            case 1:
                Console.WriteLine("You've walked into " + objects[i]);
                break;

            case 2:
                Console.WriteLine("You've walked into " + objects[i]);
                 Random randomNum = new Random();
                 Game.GameTimer();
                Game.UnderWater.Encounter(randomNum.Next(0, Game.UnderWater.objects.Length));
                break;

            case 3:
                //lava kills us and ends game
                Console.WriteLine("You've walked into " + objects[i]);
                Game.canPlay = false;
                break;

            default:
                Console.WriteLine("Your path is clear");
                break;
        }
    }
}