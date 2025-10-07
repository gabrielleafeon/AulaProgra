using UnityEngine;

namespace AulaEnum
{
    public class Sandbox : MonoBehaviour
    {
        public Difficulty currentDifficulty = Difficulty.Easy;

        void Start()
        {
            Debug.Log("Dificuldade atual: " + currentDifficulty);
            if(currentDifficulty == Difficulty.Hard)
            {
                Debug.Log("Toma cuidadooooo");
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

            }
        }
    }
}
