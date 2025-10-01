using UnityEngine;

public class CoinColetar : MonoBehaviour
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
        PStats stats;

        stats = other.GetComponent<PStats>();

        if(stats != null)
        {
            stats.collectedCoins += 1;
            Destroy(meshRend.gameObject);
        }
    }
}
