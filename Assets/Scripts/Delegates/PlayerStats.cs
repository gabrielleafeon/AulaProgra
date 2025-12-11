using UnityEngine;

namespace AulaDelegates
{
    public class PlayerStats : MonoBehaviour
    {
        Player player;
        int jumpCount = 0;
        [SerializeField] int hp = 20;

        void Start()
        {
            player = GetComponent<Player>();
            player.OnPlayerJumped += UpdateJumpCount;
            player.OnPlayerDeath += PlayerDeath;
        }

        void Update()
        {
        
        }

        void OnDisable()
        {
            player.OnPlayerJumped -= UpdateJumpCount;
            player.OnPlayerDeath -= PlayerDeath;
        }

        void UpdateJumpCount()
        {
            jumpCount++;
            Debug.Log($"Total de pulos: {jumpCount}");
        }



        void PlayerDeath()
        {
            Debug.Log("Player died :(");
        }
    }
}
