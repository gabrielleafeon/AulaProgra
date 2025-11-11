using UnityEngine;

public class InimigoTest : MonoBehaviour
{
    public PlayerTest player;
    void Awake()
    {
        Debug.Log(player.Health);
        Debug.Log($"{player.HealthPercentage}%");
        player.Health -= 50;
        Debug.Log(player.Health);
        Debug.Log($"{player.HealthPercentage}%");
    }

    void Update()
    {
        
    }
}
