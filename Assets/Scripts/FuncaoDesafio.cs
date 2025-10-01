using UnityEngine;

public class FuncaoDesafio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float vel = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            vel = -vel;
        }
        transform.Rotate(0, vel, 0);

    }
}
