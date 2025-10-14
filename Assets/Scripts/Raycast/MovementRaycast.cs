using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementRaycast : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 6f;
    public float moveForce = 2f;
    public float distanciaRaycast = 1.1f;
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
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (Physics.Raycast(this.gameObject.transform.position, new Vector3 (0, -1, 0), distanciaRaycast))
            {
                Debug.Log("Tocou o chão");
            }
            else
            {
                Debug.Log("Está no ar");
            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 linVelo = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.linearVelocity.y, rb.linearVelocity.z);
        rb.linearVelocity = linVelo;
    }

}
