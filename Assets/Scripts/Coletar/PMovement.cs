using UnityEngine;

public class PMovement : MonoBehaviour
{
    public float jumpForce = 6f;
    public float moveForce = 2f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.linearVelocity.y, Input.GetAxis("Vertical") * moveForce);
    }
}
