using System;
using UnityEngine;

namespace Genericos
{
    public class Compare : MonoBehaviour
    {
        public Peixe fish;
        public Pinguim penguin;
        void Start()
        {
            Debug.Log(Max<Animal>(fish, penguin));
        }

        void Update()
        {
        
        }

        /// <summary>
        /// Se eles são iguais, retorna arg1
        /// </summary>
        public T Max<T>(T arg1, T arg2) where T : IComparable
        {
            int comparacao = arg1.CompareTo(arg2);
            if (comparacao == -1)
            {
                return arg2;
            }
            else
            {
                return arg1;
            }
        }
    }
}
