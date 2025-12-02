using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

namespace CourotineLesson
{
    public class NPCOriginal : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] TextMeshProUGUI face;
        [SerializeField] List<Plataforma> plataformas;
        [SerializeField] float delayCoroutine;
        MeshRenderer meshRend;

        void Start()
        {
            meshRend = this.GetComponent<MeshRenderer>();
            StartCoroutine(NPCCoroutine());
        }

        IEnumerator NPCCoroutine()
        {
            //meshRend.material.color = Color.darkGreen;
            //Debug.Log(fala);

            int lastColor = -1;

            while (true)
            {
                yield return new WaitForSeconds(delayCoroutine);

                int currentColor = Random.Range(0, plataformas.Count);
                if (lastColor != currentColor)
                {
                    Plataforma plataforma = plataformas[currentColor];
                    Debug.Log(plataforma.Fala);
                    face.text = plataforma.Face;
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
