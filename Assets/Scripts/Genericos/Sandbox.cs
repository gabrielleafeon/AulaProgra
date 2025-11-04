using UnityEngine;

namespace Genericos
{
    public class Sandbox : MonoBehaviour
    {
        public Habitat<Leao> habitatLeao;
        public Habitat<Pinguim> habitatPinguim;

        void Start()
        {
            habitatLeao.NumeroDePatas();
            Debug.Log(habitatLeao.PrimeiroAnimal().tamanhoJuba);
            Debug.Log(habitatPinguim.PrimeiroAnimal().numPenas);
        }

        void Update()
        {
        
        }
    }
}
