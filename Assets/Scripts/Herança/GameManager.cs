using UnityEngine;

namespace Heranca
{
    public class GameManager : MonoBehaviour
    {
        public Spawner activeSpawner;

        void Start()
        {
            activeSpawner.Spawn();
        }

        void Update()
        {
        
        }
    }
}
