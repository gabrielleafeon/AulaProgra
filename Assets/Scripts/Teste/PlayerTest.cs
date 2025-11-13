using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] float health = 100;
    float maxHealth = 500;
    
    public float Health
    {
        get
        {
            return health;        
        }

        set
        {           
            health = value;
            ValidateHealth();
        }
    }

    public float HealthPercentage
    {
        get
        {
            return Health / maxHealth * 100;
        }
    }

    private float dano;
    public float Dano => dano;

    void Start()
    {
        ValidateHealth();
    }

    void ValidateHealth()
    {
        if (health < 0)
        {
            health = 0;
        }
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

}
