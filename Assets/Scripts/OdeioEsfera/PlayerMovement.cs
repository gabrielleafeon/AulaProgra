using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer meshRend;
    public Camera playerCamera;
    public float jumpForce = 6f;
    public float moveForce = 2f;
    public int doubleJumpCounter = 0;
    public Mesh cubeMesh;
    public TextMeshProUGUI collectedCoins;
    int cubeCounter = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = new Color(0, 0, 0);
    }
    void Update()
    {
        playerCamera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, playerCamera.transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space) && (doubleJumpCounter <= 1))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

            doubleJumpCounter += 1;
        }

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.linearVelocity.y, rb.linearVelocity.z);    
    }

    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer meshRenderer;
        MeshFilter meshFilter;
        meshRenderer = other.GetComponent<MeshRenderer>();
        meshFilter = other.GetComponent<MeshFilter>();

        if (other.gameObject.name == "Sphere")
        {
            cubeCounter += 1;

            meshFilter.mesh = cubeMesh;
            meshRenderer.material.color = new Color(0f, 0.9f, 0.6f);
            meshRend.material.color = new Color(cubeCounter/16f, 0f, 0f);

            SphereCollider sphereCollider;
            sphereCollider = other.GetComponent<SphereCollider>();
            sphereCollider.enabled = false;

            if(cubeCounter < 16)
            {
                collectedCoins.text = "Need to collect: " + (16 - cubeCounter);
            }
            else
            {
                collectedCoins.text = "Yippieeee! :)";
            }

                other.gameObject.name = ("Cube " + cubeCounter);
        }
    }
}
