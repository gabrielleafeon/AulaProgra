using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public class Peixe : Animal, INadador
    {
        public TipoDeAgua tipoDeAgua;

        public Peixe(string nome, TipoDeAgua tipoDeAgua) : base(nome)
        {
            this.tipoDeAgua = tipoDeAgua;
        }

        public TipoDeAgua GetAgua()
        {
            return tipoDeAgua;
        }

        public void Nadar(TipoDeAgua tipoDeAgua)
        {
            if (this.tipoDeAgua == GetAgua())
            {
                Debug.Log("Glub Glub");
            }
            else
            {
                Debug.Log("x_x");
            }
        }
    }
}
