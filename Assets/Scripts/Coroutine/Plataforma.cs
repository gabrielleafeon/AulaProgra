using UnityEngine;

namespace CourotineLesson
{
    public class Plataforma : MonoBehaviour
    {
        [SerializeField] string fala;
        [SerializeField] string face;
        [SerializeField] Color cor;
        [SerializeField] Vector3 offset;

        public string Fala { get => fala; set => fala = value; }
        public string Face { get => face; set => face = value; }
        public Color Cor { get => cor; set => cor = value; }
        public Vector3 Offset { get => offset; set => offset = value; }

        void Start()
        {
        
        }

        void Update()
        {
        
        }
    }
}
