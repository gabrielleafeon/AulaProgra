using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Pinguim : Animal
    {
        public int numPenas;

        public Pinguim(string nome, int numPatas, int numPenas) : base(nome, numPatas)
        {
            this.numPenas = numPenas;
        }
    }
}
