using UnityEngine;

namespace Heranca
{
    public class SpawnerCapsule : SpawnerObj
    {
        protected override GameObject CreateObj()
        {
            return GameObject.CreatePrimitive(PrimitiveType.Capsule);
        }
    }
}
