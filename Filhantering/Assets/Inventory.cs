using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Search;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    List<Inventory> items = new List<Inventory>();

    public TMP_Text text;    
    Potion HpPotion = new Potion("Health Potion", 50, 10);

    public void SaveInventory()
    {
        items.Add(HpPotion);
    }

    public void DisplayInventory()
    {
        text.text = $"{HpPotion}";
    }
}
