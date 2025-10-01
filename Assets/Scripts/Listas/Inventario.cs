using UnityEngine;

public class Inventario : MonoBehaviour
{
    Item item0 = new Item("Poção", 0, 10);
    Item item1 = new Item("Espada", 10, 20);
    Item item2 = new Item("Escudo", 5, 30);
    Item item3 = new Item("Cajado", 3, 100);
    Item item4 = new Item("Pokébola", 10, 1);

    void Start()
    {
        Lista inventario = new Lista();
        inventario.AddItem(item0);
        inventario.AddItem(item1);
        inventario.AddItem(item2);
        inventario.AddItem(item3);
        inventario.AddItem(item4);
        inventario.RemoveItem(4);
        //inventario.RemoveLast();
        inventario.PrintAll();
    }

    void Update()
    {
        
    }
}
