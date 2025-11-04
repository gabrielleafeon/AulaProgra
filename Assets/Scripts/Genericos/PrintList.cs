using System.Collections.Generic;
using UnityEngine;

namespace Genericos
{
    public class PrintList : MonoBehaviour
    {
        public List<int> listaNum;
        public List<string> listaNome;
        public List<GameObject> listaObj;

        void Start()
        {
            PrintListElements(listaNum);
            PrintListElements(listaNome);
            PrintListElements(listaObj);
        }

        void Update()
        {
        
        }
        public void PrintListElements<T>(List<T> lista)
        {
            Debug.Log($" = = {typeof(T)} = = ");
            foreach (T obj in lista)
            {               
                Debug.Log(obj);
            }
        }
    }
}
