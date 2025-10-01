using UnityEngine;

public class Escopo : MonoBehaviour
{
    // 1. Definição
    // 2. Inicialização
    // 3. Atribuição
    int vidas;
    float mana;
    string nome;
    void Start()
    {
        int vidas = 30;
        mana = 16.5f;
        nome = "Gabriel";

        Debug.Log(vidas);
        Debug.Log(mana);
        Debug.Log(nome);
    }
    void Update()
    {
        vidas = 20;
        float mana = 15.5f;
        string nome = "Milani";

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(vidas);
            Debug.Log(mana);
            Debug.Log(this.nome + " " + nome);
        }

    }
}
