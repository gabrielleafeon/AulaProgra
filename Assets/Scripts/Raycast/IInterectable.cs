using UnityEngine;

namespace Raycast
{
    public interface IInteractable
    {
        public void Interact(MovementRaycast player);
    }
}
