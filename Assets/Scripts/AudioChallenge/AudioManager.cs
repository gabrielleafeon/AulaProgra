using UnityEngine;

namespace AudioChallenge
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;
        FakeAudioSource audioSource;
        int contador = 0;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }

            audioSource = GetComponentInChildren<FakeAudioSource>();               
        }

        void Start()
        {
            
        }

        void Update()
        {
        
        }

        public void PlayAudio(string audio)
        {
            audioSource.PlayOneShot(audio);
            contador += 1;
        }

    }
}
