using UnityEngine;

namespace AudioChallenge
{
    public class Player : MonoBehaviour
    {

        void Start()
        {
            AudioManager.Instance.PlayAudio("Ow");
        }

        void Update()
        {
        
        }
    }
}
