using System.Collections.Generic;
using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Habitat<T> where T : Animal
    {
        public List<T> animais;

        public Habitat()
        {
            animais = new List<T>();
        }

        public T PrimeiroAnimal()
        {
            return animais[0];
        }

        public void AdicionarAnimal(T animal)
        {
            animais.Add(animal);
        }

        public void NumeroDePatas()
        {
            int totalPatas = 0;

            foreach(T animal in animais)
            {
                totalPatas += animal.numPatas;             
            }
            Debug.Log("Número de patas: " + totalPatas);
        }
    }

}
