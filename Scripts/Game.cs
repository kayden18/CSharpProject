using System;

public class Game
{

    public Game(){
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
    }

    public void Start(){
        Health.RunPowerUp();
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
    }
    //Game powerups
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    //gam weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();


    public string name;
    private int score;

}