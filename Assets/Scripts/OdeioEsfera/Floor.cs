using UnityEngine;

public class Floor : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement playerMov;

        playerMov = other.GetComponent<PlayerMovement>();
        
        if(playerMov != null)
        {
            playerMov.doubleJumpCounter = 0;
        }           
    }
}
