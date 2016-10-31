using System;

public class Game{
    public static bool canPlay = true;
    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have enterted a cave.";
        UnderWater.objects = new String[]{"SeaWead", "Coral", "Fish", "shark" };
    }
    //runs at the start of the game
    public void Start(){
        Console.WriteLine("Please type in your name:");
        name = Console.ReadLine();
        Console.WriteLine("Your Player name is " + name);
        Cave.Enter();
        while (Game.canPlay){
            GameTimer();
            Play();
        }
        Console.WriteLine("You Died");
        Console.WriteLine("Game Over");
    }
    private void Play (){
        Random randomNum = new Random();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }

    public static void GameTimer (){
        System.Threading.Thread.Sleep(2000);
    }
    //game levels
    private LevelBase Cave = new LevelBase();
    public static LevelBase UnderWater = new LevelBase();
    //Game powerups
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    //game weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    
    public string name;
    private int score;

}
/*
        After prompt the game for a name we:
        Enter a cave
        find Health.
        Meet a dragon. (need an enemy class)
        pick weapon.
        battle dragon. (battle class)
        if we win: get health and ammo
        if dragon wins: we loose health;
        */
