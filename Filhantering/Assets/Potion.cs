using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Inventory
{
    public string name;
    public int HpGenTotal;
    public int HpGenTime; //seconds

    public Potion(string name, int HpGenTotal, int HpGenTime)
    {
        this.name = name;
        this.HpGenTotal = HpGenTotal;
        this.HpGenTime = HpGenTime;
    }
}
