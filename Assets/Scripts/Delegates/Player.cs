using UnityEngine;

namespace AulaDelegates
{
    public class Player : MonoBehaviour
    {
        public delegate void PlayerHandler();

        public PlayerHandler OnPlayerJumped;

        void Start()
        {
            
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnPlayerJumped();
            }
        }

    }
}
