using UnityEngine;

public class Funcoes : MonoBehaviour
{
    void Start()
    {
        PrintDecimal(0.5f);
        PrintFrase("Olá tudo bem");
        Debug.Log(PrintSoma(2, 5));
        PrintTabuada(5);
    }

    void Update()
    {
        
    }

    void PrintDecimal(float num)
    {
        Debug.Log(num / 2);
    }

    void PrintFrase(string frase)
    {
        Debug.Log("(" + frase + ")");
    }

    int PrintSoma(int num1, int num2)
    {
        return num1 + num2;
    }

    void PrintTabuada (int num)
    {
        string frase;
        frase = num + " * 1 = " + num * 1 + "\n"; 
        frase += num + " * 2 = " + num * 2 + "\n";
        frase += num + " * 3 = " + num * 3 + "\n";
        frase += num + " * 4 = " + num * 4 + "\n";
        frase += num + " * 5 = " + num * 5 + "\n";
        frase += num + " * 6 = " + num * 6 + "\n";
        frase += num + " * 7 = " + num * 7 + "\n";
        frase += num + " * 8 = " + num * 8 + "\n";
        frase += num + " * 9 = " + num * 9;
        Debug.Log(frase);
    }
}
