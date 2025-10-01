using UnityEngine;

public class Item 
{
    public string name;
    public int dmg;
    public int durability;
    public Item nextItem;

    public Item(string name, int dmg, int durability)
    {
        if (string.IsNullOrEmpty(name))
        {
            name = "Vazio";
        }
        this.name = name;

        if (dmg < 0)
        {
            dmg = 0;
        }
        this.dmg = dmg;

        if (durability < 0)
        {
            durability = 0;
        }
        this.durability = durability;
    }

    //public Item()
    //{
    //    this.name = "Vazio";
    //    this.dmg = 0;
    //    this.durability = 0;
    //}

    public void PrintInfo()
    {
        Debug.Log($"Name: {name} Damage: {dmg} Durability: {durability}");
    }
}