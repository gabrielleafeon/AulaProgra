using UnityEngine;

namespace ExercicioID
{
    public static class Extensions
    {
        public static T ReturnObject<T>(T obj)
        {
            return obj;
        }

        public static bool HasComponent<T>(GameObject obj)
        {
            T component = obj.GetComponent<T>();
            if (component.ToString() != "null")
            {
                Debug.Log("Tem o componente " + typeof(T));
                return true;
            }
            else
            {
                Debug.Log("Não tem o componente " + typeof(T));
                return false;
            }
            
        }
    }
}
