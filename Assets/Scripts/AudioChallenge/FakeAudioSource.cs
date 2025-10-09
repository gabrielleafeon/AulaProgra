using UnityEngine;

namespace AudioChallenge
{
    public class FakeAudioSource : MonoBehaviour
    {
        public void PlayOneShot(string audio)
        {
            Debug.Log($"Toquei \"{audio}\"!");
        }
    }
}
