using UnityEngine;

public class SpikeColetar : MonoBehaviour
{
    public int damage = 2;
    public float cooldownMax = 2;
    float cooldown;
    Color originalColor;

    void Start()
    {
        //Application.targetFrameRate = 5;
    }

    void Update()
    {
        //cooldown += Time.deltaTime;
        //print(cooldown + "/" + Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PStats life;
        MeshRenderer meshRend;

        life = other.GetComponent<PStats>();
        meshRend = other.GetComponent<MeshRenderer>();
        originalColor = meshRend.material.color;
    }
    private void OnTriggerStay(Collider other)
    {
        PStats life;
        MeshRenderer meshRend;

        life = other.GetComponent<PStats>();
        meshRend = other.GetComponent<MeshRenderer>();

        if(life != null && meshRend != null)
        {
            cooldown -= Time.deltaTime;
            meshRend.material.color = originalColor;
            if (cooldown <= 0)
            {
                life.TakeDamage(damage);

                meshRend.material.color = new Color(1f, 0f, 0f);               

                cooldown = cooldownMax;
            }             
        }
    }
}
