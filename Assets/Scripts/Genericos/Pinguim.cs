using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Pinguim : Animal, INadador, ITerPatas
    {
        public int numPenas;
        public int numPatas;

        public Pinguim(string nome, int numPenas) : base(nome)
        {
            this.numPenas = numPenas;
        }

        public TipoDeAgua GetAgua()
        {
            return TipoDeAgua.Salgada;
        }

        public void Nadar(TipoDeAgua tipoDeAgua)
        {
            if(tipoDeAgua == GetAgua())
            {
                Debug.Log("Glub Glub");
            }
            else
            {
                Debug.Log("x_x");
            }
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
