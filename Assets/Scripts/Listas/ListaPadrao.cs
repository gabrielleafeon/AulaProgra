using System.Collections.Generic;
using UnityEngine;

public class ListaPadrao : MonoBehaviour
{
    void Start()
    {

        //List<int> numeros;
        //numeros = new List<int>();
        //numeros.Add(20);
        //numeros.Add(18);
        //numeros.Add(2);
        //numeros.Add(20);
        //numeros.Add(19);
        //numeros.RemoveAt(1);
        //numeros.Remove(20);

        //for(int i = 0; i < numeros.Count; i++)
        //{
        //    print(numeros[i]);
        //}

        //List<string> pokemon;
        //pokemon = new List<string>();
        //pokemon.Add("Eevee");
        //pokemon.Add("Flareon");
        //pokemon.Add("Jolteon");
        //pokemon.Add("Vaporeon");
        //pokemon.Add("Leafeon");
        //pokemon.RemoveAt(1);
        //pokemon.Remove("Jolteon");

        //for (int i = 0; i < pokemon.Count; i++)
        //{
        //    print(pokemon[i]);
        //}

        List<Color> cores;
        cores = new List<Color>();
        cores.Add(Color.blue);
        cores.Add(Color.yellow);
        cores.Add(Color.red);
        cores.Add(Color.orange);
        cores.Add(Color.purple);
        cores.RemoveAt(1);
        cores.Remove(Color.purple);

        for (int i = 0; i < cores.Count; i++)
        {
            print(cores[i]);
        }

        //List<Item> items;
        //items = new List<Item>();
        //Item item0 = new Item("Poção", 0, 10);
        //Item item1 = new Item("Espada", 10, 20);
        //Item item2 = new Item("Escudo", 5, 30);
        //Item item3 = new Item("Cajado", 3, 100);
        //Item item4 = new Item("Pokébola", 10, 1);
        //items.Add(item0);
        //items.Add(item1);
        //items.Add(item2);
        //items.Add(item3);
        //items.Add(item4);
        //items.RemoveAt(1);
        //items.Remove(item3);

        
    }

    void Update()
    {
        
    }
}
