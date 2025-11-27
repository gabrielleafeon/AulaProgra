using System.Collections;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;
using System.Collections.Generic;

namespace CourotineLesson
{
    public class NPC : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] TextMeshProUGUI face;
        [SerializeField] List<Plataforma> plataformas;
        [SerializeField] float delayCoroutine;
        Coroutine coroutin;
        MeshRenderer meshRend;

        void Start()
        {
            meshRend = this.GetComponent<MeshRenderer>();
            coroutin = StartCoroutine(NPCCoroutine());
        }

        IEnumerator NPCCoroutine()
        {
            meshRend.material.color = Color.darkGreen;
            Debug.Log(fala);

            int lastColor = 2;

            while (true)
            {
                yield return new WaitForSeconds(delayCoroutine);

                int currentColor = Random.Range(0, plataformas.Count);
                if (lastColor != currentColor)
                {
                    Plataforma plataforma = plataformas[currentColor];                   
                    Debug.Log(plataforma.Fala);
                    yield return new WaitForSeconds(0.5f);
                    face.text = plataforma.Face;
                    yield return new WaitForSeconds(0.3f);
                    meshRend.material.color = plataforma.Cor;
                    this.transform.position = plataforma.Offset + plataforma.transform.position;
                    lastColor = currentColor;
                }
                else
                {
                    Debug.Log("Não mudei de cor :(");
                    face.text = ":(";
                }
            }            
            
        }
    }
}
