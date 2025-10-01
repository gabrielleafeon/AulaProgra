using UnityEngine;

namespace Interface
{
    public class Arma : MonoBehaviour, IColorizable
    {
        MeshRenderer meshRend;

        public void ChangeColor(Color color)
        {
            if(meshRend != null)
            {
                meshRend.material.color = color;
            }
             
        }

        void Start()
        {
            meshRend = GetComponent<MeshRenderer>();
        }

        void Update()
        {
        
        }
    }
}
