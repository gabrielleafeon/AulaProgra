using UnityEngine;
using UnityEngine.SceneManagement;

namespace Static
{
    public class Sandbox : MonoBehaviour
    {
        public GameObject gameObj;

        private void Awake()
        {
            Calculator.totalOperations += 100;

        }

        void Start()
        {
            //Utilities.PrintGameObjectAndParent(gameObj);
            //Calculator.Sum(10, 25);
            
        }

        void Update()
        {
            Debug.Log(Utilities.myCounter);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Utilities.myCounter += 1;
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Scene cenaAtual = SceneManager.GetActiveScene();
                
                if (cenaAtual.buildIndex == 0)
                {
                    SceneManager.LoadScene(1);
                }
                if (cenaAtual.buildIndex == 1)
                {
                    SceneManager.LoadScene(0);
                }

            }
        }
    }
}
