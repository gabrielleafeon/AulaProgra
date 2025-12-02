using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

namespace CourotineLesson
{
    public class NPC : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] TextMeshProUGUI face;
        [SerializeField] int pontos;
        [SerializeField] Vector3 posInicial;
        [SerializeField] Color teamColor;
        MeshRenderer meshRend;


        public int Pontos { get => pontos; set => pontos = value; }
        public Vector3 PosInicial { get => posInicial; }

        public Color TeamColor { get => teamColor; }

        void Start()
        {
            posInicial = this.gameObject.transform.position;
            meshRend = this.GetComponent<MeshRenderer>();
        }

        public IEnumerator Delay()
        {
            Debug.Log("Comecei delay");
            yield return new WaitForSeconds(3f);
            Debug.Log("Terminei o delay");
        }

        public void Mover(Plataforma plataforma)
        {
            plataforma.ReduzirUso(this);
            Debug.Log(plataforma.Fala);
            face.text = plataforma.Face;
            meshRend.material.color = plataforma.Cor;
            this.transform.position = plataforma.Offset + plataforma.transform.position;
        }
    }
}
