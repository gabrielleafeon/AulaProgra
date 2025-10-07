using UnityEngine;

namespace Static
{
    public static class Utilities
    {
        public static int myCounter;

        public static void PrintGameObjectAndParent(GameObject gameObject)
        {
            Debug.Log($"{gameObject.name} � filho de {gameObject.transform.parent.name}");
        }


    }
}
