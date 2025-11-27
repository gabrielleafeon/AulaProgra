using System.Collections;
using UnityEngine;

namespace CourotineLesson
{
    public class MultiplasAcoes : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(Inicializacao());
        }

        void Update()
        {

        }

        IEnumerator Inicializacao()
        {
            Debug.Log("Iniciando");
            yield return IniciarRender();
            yield return null;
            yield return CarregarSave();
            Debug.Log("Terminei de iniciar");
        }

        IEnumerator IniciarRender()
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log("Iniciei o render");
        }

        IEnumerator CarregarSave()
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log("Carreguei o save");
        }
    }
}
