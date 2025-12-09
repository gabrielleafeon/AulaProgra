using UnityEngine;

namespace AulaDelegates
{
    public class PlayerStats : MonoBehaviour
    {
        Player player;
        int jumpCount = 0;

        void Start()
        {
            player = GetComponent<Player>();
            player.OnPlayerJumped += UpdateJumpCount;
        }

        void Update()
        {
        
        }

        void UpdateJumpCount()
        {
            jumpCount++;
            Debug.Log($"Total de pulos: {jumpCount}");
        }
    }
}
