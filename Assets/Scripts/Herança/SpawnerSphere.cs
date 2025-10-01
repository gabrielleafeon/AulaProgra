using UnityEngine;

namespace Heranca
{
    public class SpawnerSphere : SpawnerObj
    {
        protected override GameObject CreateObj()
        {
            return GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
    }
}
