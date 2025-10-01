using UnityEngine;

namespace Heranca
{
    public abstract class SpawnerObj : Spawner
    {
        public Vector3 position;
        public Color cor;

        public override void Spawn()
        {
            GameObject obj;
            obj = CreateObj();
            obj.transform.position = position;
            MeshRenderer meshRend;
            meshRend = obj.GetComponent<MeshRenderer>();
            meshRend.material.color = cor;
        }

        protected abstract GameObject CreateObj();
    }
}
