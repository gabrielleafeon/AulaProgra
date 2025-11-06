using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Leao : Animal, ITerPatas
    {
        public float tamanhoJuba;
        public int numPatas;

        public Leao(string nome, float tamanhoJuba) : base(nome)
        {
            this.tamanhoJuba = tamanhoJuba;
        }

        public int NumeroPatas()
        {
            return numPatas;
        }

        public void SetarPatas(int numPatas)
        {
            this.numPatas = numPatas;
        }
    }
}
