using Raycast;
using UnityEditor.PackageManager;
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
    public float radius = 1;
    public Vector3 cubeSize;
    public float maxDistance = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        layerMask = (1 << LayerMask.NameToLayer("Ground")) | (1 << LayerMask.NameToLayer("Player"));
                //= LayerMask.GetMask("Ground", "Player"); (Mesma coisa do de cima)
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
            if (Physics.Raycast(this.gameObject.transform.position, Vector3.down, out hitInfo, this.distanciaRaycast, this.mask)) // ou usar LayerMask.GetMask("Player", "Ground")
            {
                this.InteractRaycast(hitInfo.collider.gameObject);
            }
            else
            {
                Debug.Log("Está no ar");
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            RaycastHit[] objects = Physics.RaycastAll(this.gameObject.transform.position, Vector3.down, this.distanciaRaycast, this.mask);

            foreach(RaycastHit objectHit in objects)
            {
                this.InteractRaycast(objectHit.collider.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Collider[] colliders = Physics.OverlapSphere(this.gameObject.transform.position, radius, this.mask);

            foreach(Collider collide in colliders)
            {
                this.InteractRaycast(collide.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Collider[] colliders = Physics.OverlapBox(this.gameObject.transform.position, cubeSize/2, 
                                                      this.gameObject.transform.rotation, this.mask);

            foreach (Collider collide in colliders)
            {
                this.InteractRaycast(collide.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {          
            if(Physics.SphereCast(this.gameObject.transform.position, radius, Vector3.right, out RaycastHit hitInfo, maxDistance, this.mask))
            {
                this.InteractRaycast(hitInfo.collider.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            RaycastHit[] objects = Physics.SphereCastAll(this.gameObject.transform.position, radius, Vector3.right, 
                                                         maxDistance, this.mask);
            foreach (RaycastHit objectHit in objects)
            {
                this.InteractRaycast(objectHit.collider.gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            RaycastHit[] objects = Physics.BoxCastAll(this.gameObject.transform.position, cubeSize/2, Vector3.right,
                                                      this.gameObject.transform.rotation, maxDistance, this.mask);
            foreach (RaycastHit objectHit in objects)
            {
                this.InteractRaycast(objectHit.collider.gameObject);
            }
        }

    }

    private void FixedUpdate()
    {
        Vector3 linVelo = new Vector3(Input.GetAxis("Horizontal") * moveForce, rb.linearVelocity.y, rb.linearVelocity.z);
        rb.linearVelocity = linVelo;
    }

    public void InteractRaycast(GameObject hitObject)
    {
        IInteractable interagivel = hitObject.GetComponent<IInteractable>();
        if (interagivel != null)
        {
            interagivel.Interact(this);
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawWireSphere(this.gameObject.transform.position, radius);
        Gizmos.DrawWireCube(this.gameObject.transform.position, cubeSize);
    }

}
