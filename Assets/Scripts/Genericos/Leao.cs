using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Leao : Animal
    {
        public float tamanhoJuba;

        public Leao(string nome, int numPatas, float tamanhoJuba) : base(nome, numPatas)
        {
            this.tamanhoJuba = tamanhoJuba;
        }
    }
}
