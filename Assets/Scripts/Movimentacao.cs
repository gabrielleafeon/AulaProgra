using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float velocidade = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, velocidade * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidade * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -velocidade * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidade * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            velocidade += 0.01f;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            velocidade -= 0.01f;
        }
    }
}
