using UnityEngine;

public class Inventory : MonoBehaviour
{
    const int num = 100;
    Item[] itens = new Item[num];
    
    
    void Start()
    {
        PlayerData player1 = new PlayerData(20, 30);
        PlayerData player2 = new PlayerData(25, 25);

        //Debug.Log(player2.health);

        for (int i = 0; i < num; i++)
        {
            Item item = new Item(Random.Range(0, 50).ToString(),
                                 Random.Range(0, 100),
                                 Random.Range(0, 20));

            item.PrintInfo();

            itens[i] = item;          
        }


    }

    void Update()
    {
        
    }
}
