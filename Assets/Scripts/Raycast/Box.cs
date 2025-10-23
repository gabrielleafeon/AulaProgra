using UnityEngine;

namespace Raycast
{
    public class Box : MonoBehaviour, IInteractable
    {
        public void Interact(MovementRaycast player)
        {
            MeshRenderer meshRend = player.gameObject.GetComponent<MeshRenderer>();
            meshRend.material.color = Color.azure;
        }

        void Start()
        {
        
        }

        void Update()
        {
        
        }
    }
}
