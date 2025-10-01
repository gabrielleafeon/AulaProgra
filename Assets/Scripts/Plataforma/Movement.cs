using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    //float positionX = -3.5f;
    public float jumpForce = 6f;
    public float moveForce = 2f;
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
        //print(rb.linearVelocity);
    }

    private void FixedUpdate()
    {
        Vector3 linVelo = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.linearVelocity.y, rb.linearVelocity.z);
        rb.linearVelocity = linVelo;

        //positionX += Input.GetAxis("Horizontal") * Time.fixedDeltaTime * moveForce;
        //Vector3 position = new Vector3(positionX, this.transform.position.y, this.transform.position.z);
        //rb.MovePosition(position);
    }

    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer meshRenderObjetos;

        meshRenderObjetos = other.GetComponent<MeshRenderer>();
        meshRenderObjetos.material.color = new Color(1f, 0f, 0f);

        MeshRenderer meshRenderPlayer;

        meshRenderPlayer = this.GetComponent<MeshRenderer>();
        meshRenderPlayer.material.color = new Color(0f, 1f, 0f);
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

}
