using UnityEngine;

namespace Heranca
{
    public class SpawnerCube : SpawnerObj
    {
        protected override GameObject CreateObj()
        {
            return GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
    }
}
