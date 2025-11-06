using UnityEngine;

namespace Genericos
{
    public class Sandbox : MonoBehaviour
    {
        public Habitat<Leao> habitatLeao;
        public Habitat<Pinguim> habitatPinguim;
        public Habitat<Peixe> habitatPeixe;
        public Habitat<Minhoca> habitatMinhoca;

        void Start()
        {
            //habitatLeao.NumeroDePatas();
            //Debug.Log(habitatLeao.PrimeiroAnimal().tamanhoJuba);
            //Debug.Log(habitatPinguim.PrimeiroAnimal().numPenas);
            //habitatPeixe.PrimeiroAnimal().Nadar(TipoDeAgua.Doce);
            //habitatPinguim.SelecionarAnimal(1).Nadar(TipoDeAgua.Salgada);
            //HabitatComAgua(habitatPeixe, TipoDeAgua.Doce);
            HabitatCheck(habitatPinguim.PrimeiroAnimal());
        }

        void Update()
        {
        
        }

        public void HabitatComAgua<T>(Habitat<T> habitat, TipoDeAgua tipoDeAgua) where T : Animal, INadador
        {
            foreach (T animal in habitat.animais)
            {
                animal.Nadar(tipoDeAgua);
            }
        }

        public void HabitatCheck<T>(T animal) where T : Animal, INadador, ITerPatas
        {
            Debug.Log($"Eu tenho {animal.NumeroPatas()} patas, e nado em águas {animal.GetAgua()}");
        }
    }
}
