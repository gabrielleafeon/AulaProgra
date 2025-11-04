using UnityEngine;

namespace ExercicioID
{
    public class Pair<T1,T2>
    {
        public T1 obj1;
        public T2 obj2;

        public Pair(T1 obj1, T2 obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }

        public bool CompareObject(T1 obj)
        {
            return(obj1.Equals(obj));            
        }
    }
}
