using UnityEngine;

namespace Genericos
{
    public interface INadador
    {
        public void Nadar(TipoDeAgua tipoDeAgua);
        public TipoDeAgua GetAgua();
    }
}
