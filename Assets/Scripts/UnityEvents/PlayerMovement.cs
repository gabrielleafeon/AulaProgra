using UnityEngine;

namespace AulaUnityEvents
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;
        [SerializeField] float forceY;
        Player player;
        void Start()
        {
            player = GetComponentInParent<Player>();
            player.OnPlayerJumped.AddListener(Jump);
            rb = GetComponentInParent<Rigidbody>();
        }

        void Update()
        {
        
        }

        public void Jump()
        {
            rb.AddForce(new Vector3(0, forceY, 0));
        }

        private void OnDestroy()
        {
            player.OnPlayerJumped.RemoveListener(Jump);
        }
    }
}
