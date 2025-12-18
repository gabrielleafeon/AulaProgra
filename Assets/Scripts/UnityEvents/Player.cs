using UnityEngine;
using UnityEngine.Events;

namespace AulaUnityEvents
{
    public class Player : MonoBehaviour
    {
        public UnityEvent OnPlayerJumped;
        public UnityEvent<int> OnPlayerChangeHealth;

        public int hp = 20;

        void Start()
        {
            OnPlayerChangeHealth.Invoke(hp);
            OnPlayerJumped.AddListener(PrintJump);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnPlayerJumped.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                hp -= 1;
                OnPlayerChangeHealth.Invoke(hp);
            }
        }

        void PrintJump()
        {
            Debug.Log("Pulei");
        }
    }
}
