using UnityEngine;
using UnityEngine.UI;

public class PStats : MonoBehaviour
{
    [SerializeField] int life = 100;
    public int collectedCoins = 0;
    public Lifebar lifebar;
    void Start()
    {
        lifebar.LifeChange(life);
    }

    public void TakeDamage(int damage)
    {
        life -= damage;
        lifebar.LifeChange(life);
    }

}
