using System;

[Serializable]
public class PlayerData
{
    public string Name;
    public int health;
    public int age;

    public PlayerData (Player player)
    {
        Name = player.Name;
        health = player.health;
        age = player.age;
    }
}
