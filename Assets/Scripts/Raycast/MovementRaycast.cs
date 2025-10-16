using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementRaycast : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 6f;
    public float moveForce = 2f;
    public float distanciaRaycast = 1.1f;
    int layerMask;
    public LayerMask mask;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        layerMask = (1 << LayerMask.NameToLayer("Ground")) | (1 << LayerMask.NameToLayer("Player"));
        Debug.Log((int)mask);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {          
            RaycastHit hitInfo;
            if (Physics.Raycast(this.gameObject.transform.position, Vector3.down, out hitInfo, distanciaRaycast, mask)) // ou usar LayerMask.GetMask("Player", "Ground")
            {
                GameObject hitObject;
                hitObject = hitInfo.collider.gameObject;
                MeshRenderer meshRend;
                meshRend = hitObject.GetComponent<MeshRenderer>();

                meshRend.material.color = Color.red;
                Debug.Log($"Tocou o {hitObject.name}, está na layer {hitObject.layer}");
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
