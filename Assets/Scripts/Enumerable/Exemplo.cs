using UnityEngine;

namespace AulaEnumerable
{
    public class Exemplo : MonoBehaviour
    {
        [SerializeField] Sandbox sandbox;
        void Start()
        {
            foreach(object obj in sandbox)
            {
                Debug.Log(obj);
            }
        }

        void Update()
        {
        
        }
    }
}
