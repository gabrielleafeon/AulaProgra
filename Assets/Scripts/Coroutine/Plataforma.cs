using System.Collections;
using UnityEngine;
using TMPro;

namespace CourotineLesson
{
    public class Plataforma : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] string face;
        [SerializeField] int usos;
        [SerializeField] Color cor;
        [SerializeField] Vector3 offset;
        TextMeshProUGUI usosDisplay;

        public string Fala { get => fala; set => fala = value; }
        public string Face { get => face; set => face = value; }
        public int Usos { get => usos; set => usos = value; }
        public Color Cor { get => cor; set => cor = value; }
        public Vector3 Offset { get => offset; set => offset = value; }

        void Start()
        {
            usosDisplay = this.GetComponentInChildren<TextMeshProUGUI>();
            usosDisplay.text = usos.ToString();
        }

        void Update()
        {
        
        }

        public void ReduzirUso(NPC player)
        {
            if(usos <= 0)
            {
                Debug.Log("Não pode mais reduzir");
                return;
            }

            usos -= 1;
            usosDisplay.text = usos.ToString();
            if(usos == 0)
            {
                ZeroUsos(player);
            }
        }

        void ZeroUsos(NPC player)
        {
            usosDisplay.text = player.name;
            //usosDisplay.color = player.TeamColor; 
            player.Pontos += 1;
        }
    }
}
