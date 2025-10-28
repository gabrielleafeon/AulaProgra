using UnityEngine;

namespace ExercicioID
{
    public class Lista<T>
    {
        Element<T> head;

        public Lista()
        {
            head = null;
        }

        public void AddItem(T item)
        {
            Element<T> currentItem = head;
            if (currentItem == null)
            {
                head = new Element<T>(item);
                return;
            }

            while (currentItem.nextItem != null)
            {
                currentItem = currentItem.nextItem;
            }
            currentItem.nextItem = new Element<T>(item);
        }

        public void RemoveItem(int num)
        {
            Element<T> currentItem = head;
            if (currentItem == null)
            {
                Debug.LogWarning("Lista vazia");
                return;
            }

            if (num < 0)
            {
                Debug.LogWarning("Índice fora da lista");
            }

            if (num == 0)
            {
                head = currentItem.nextItem;
                return;
            }

            int i = 0;

            while (i < num - 1)
            {
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
            Element<T> currentItem = head;
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
            Element<T> currentItem = head;
            while (currentItem != null)
            {
                currentItem.PrintInfo();
                currentItem = currentItem.nextItem;
            }
        }

    }

    [System.Serializable]
    public class Element<T>
    {
        public T obj;
        public Element<T> nextItem;

        public Element(T obj)
        {
            this.obj = obj;
        }

        public void PrintInfo()
        {
            Debug.Log($"{obj}");
        }

    }
}
