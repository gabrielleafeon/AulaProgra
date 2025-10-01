using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int numInteiro = 0;
    string nomeOriginal = "Personagem";
    string nome = "Personagem";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nome = nomeOriginal + " " + numInteiro;
        gameObject.name = nome;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            numInteiro = numInteiro + 1;
            nome = nomeOriginal + " " + numInteiro;
            gameObject.name = nome;
        }
    }
}
