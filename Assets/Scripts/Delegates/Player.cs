using System;
using UnityEngine;

namespace AulaDelegates
{
    public class Player : MonoBehaviour
    {
        public Action OnPlayerJumped;
        public Action OnPlayerDeath;
        public Action<int> OnPlayerDamageTaken;
        public Action<int> OnPlayerHealing;

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnPlayerJumped();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                OnPlayerDeath();
            }
        }

    }
}
