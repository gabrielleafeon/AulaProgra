using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Progress;

public class Lista 
{
    Item head;

    public Lista() 
    {
        head = null;
    }

    public void AddItem(Item item)
    {
        Item currentItem = head;
        if(currentItem == null)
        {
            head = item;
            return;
        }

        while(currentItem.nextItem != null)
        {
            currentItem = currentItem.nextItem;
        }
        currentItem.nextItem = item;
    }

    public void RemoveItem(int num)
    {
        Item currentItem = head;
        if (currentItem == null)
        {
            Debug.LogWarning("Lista vazia");
            return;
        }

        if(num < 0)
        {
            Debug.LogWarning("Índice fora da lista");
        }

        if(num == 0)
        {
            head = currentItem.nextItem;
            return;
        }

        int i = 0;

        while (i < num - 1) {
            currentItem = currentItem.nextItem;

            if (currentItem.nextItem == null)
            {
                Debug.LogWarning("Índice fora da lista");
                return;
            }

            i++;
        }

        currentItem.nextItem = currentItem.nextItem.nextItem;
        
        
    }

    public void RemoveLast()
    {
        Item currentItem = head;
        if (currentItem == null)
        {
            Debug.LogWarning("Lista vazia");
            return;
        }

        while (currentItem.nextItem.nextItem != null)
        {
            currentItem = currentItem.nextItem;
        }

        currentItem.nextItem = currentItem.nextItem.nextItem;
    }

    public void PrintAll()
    {
        Item currentItem = head;
        while(currentItem != null)
        {
            currentItem.PrintInfo();
            currentItem = currentItem.nextItem;
        }
    }
}
