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

        public T SelecionarAnimal(int num)
        {
            if((num < animais.Count) && (num >= 0))
            {
                return animais[num];
            }
            else
            {
                return null;
            }
        }

        public void AdicionarAnimal(T animal)
        {
            animais.Add(animal);
        }
    }

}
