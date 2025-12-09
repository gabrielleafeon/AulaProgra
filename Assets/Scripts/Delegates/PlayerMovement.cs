using UnityEngine;

namespace AulaDelegates
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float jumpForce;
        Player player;
        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            player = GetComponent<Player>();
            player.OnPlayerJumped += Jump;
        }

        void Update()
        {
        
        }

        void Jump()
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
}
