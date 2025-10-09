using UnityEngine;

namespace AudioChallenge
{
    public class Player : MonoBehaviour
    {

        void Start()
        {
            AudioManager.instance.PlayAudio("Ow");
        }

        void Update()
        {
        
        }
    }
}
