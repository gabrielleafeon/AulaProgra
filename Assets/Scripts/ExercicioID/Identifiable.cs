using UnityEngine;

namespace ExercicioID
{
    [System.Serializable]
    public class Identifiable<T>
    {
        public T obj;
        public int id;

        public Identifiable(T obj, int id)
        {
            this.obj = obj;
            this.id = id;
        }

        public void PrintID()
        {
            Debug.Log($"[{id}] - {obj}");
        }

    }
}
