using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public abstract class Animal
    {
        public string nome;
        public int numPatas;

        public Animal(string nome, int numPatas)
        {
            this.nome = nome;
            this.numPatas = numPatas;
        }
    }
}
