using UnityEngine;

public class Comida : MonoBehaviour
{
    MeshRenderer meshRend;
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Fila cobrinha;

        cobrinha = other.GetComponentInParent<Fila>();
        cobrinha.AddBody(1);

        Destroy(meshRend.gameObject);
    }
}
