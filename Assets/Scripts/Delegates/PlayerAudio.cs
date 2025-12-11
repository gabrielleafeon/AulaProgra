using UnityEngine;

namespace AulaDelegates
{
    public class PlayerAudio : MonoBehaviour
    {
        Player player;

        void Start()
        {
            player = GetComponent<Player>();
            player.OnPlayerJumped += PlayJumpAudio;
            player.OnPlayerDeath += PlayDeathAudio;
        }

        void Update()
        {
        
        }

        void PlayJumpAudio()
        {
            Debug.Log("*Áudio de pulo*");
        }

        void PlayDeathAudio()
        {
            Debug.Log("*Áudio de morte*");
        }
    }
}
