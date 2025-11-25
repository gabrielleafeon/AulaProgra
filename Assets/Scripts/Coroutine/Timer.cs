using System.Collections;
using UnityEngine;

namespace CoroutineLesson
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] float tempo;
        Coroutine cor;

        void Start()
        {
            cor = StartCoroutine(TimerCoroutine(fala,tempo));
            //StopCoroutine(cor);
        }

        void Update()
        { 
            if (Input.GetKeyDown(KeyCode.F))
            {
                if(cor != null)
                {
                    StopCoroutine(cor);
                    cor = null;
                    Debug.Log("Parou");
                }
                else
                {
                    cor = StartCoroutine(TimerCoroutine(fala,tempo));
                }
                
            }

        }

        IEnumerator TimerCoroutine(string fala, float tempo)
        {

            Debug.Log("Preparando Timer" + Time.frameCount);

            yield return null;

            Debug.Log("Iniciando Timer" + Time.frameCount);


            while(true)
            {
                yield return new WaitForSeconds(tempo);
                //yield return new WaitForSecondsRealtime(tempo);


                Debug.Log(fala);
            }           
        }

} 
}
