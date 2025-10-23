using UnityEngine;

namespace Raycast
{
    public class Platform : MonoBehaviour, IInteractable
    {
        public void Interact(MovementRaycast player)
        {
            MeshRenderer meshRend;
            meshRend = this.GetComponent<MeshRenderer>();

            meshRend.material.color = Color.red;
            Debug.Log($"Tocou o {this.name}, está na layer {this.gameObject.layer}");
        }

        void Start()
        {
        
        }

        void Update()
        {
        
        }
    }
}
