using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public string Name = "Hugo";
    public int health = 100;
    public int age = 18;
    public TMP_Text tmp;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Name = data.Name;
        health = data.health;
        age = data.age;

        tmp.text = $"Name: {Name} \nHealth: {health} \nAge: {age}";
    }
}
