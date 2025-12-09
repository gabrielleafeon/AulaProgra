using UnityEngine;

namespace AulaDelegates
{
    public class PlayerEffects : MonoBehaviour
    {
        [SerializeField] Color onColor;
        [SerializeField] Color offColor;
        Player player;
        MeshRenderer meshRend;
        bool isOn;

        void Start()
        {
            meshRend = GetComponent<MeshRenderer>();
            player = GetComponent<Player>();
            player.OnPlayerJumped += CreateJumpParticle;
        }

        void Update()
        {
        
        }

        private void OnDisable()
        {
            player.OnPlayerJumped -= CreateJumpParticle;
        }

        void CreateJumpParticle()
        {
            if (isOn)
            {
                meshRend.material.color = onColor;
            }
            else
            {
                meshRend.material.color = offColor;                
            }
            isOn = !isOn;

        }
    }
}
