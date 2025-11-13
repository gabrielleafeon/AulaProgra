using UnityEngine;

public class Formas : MonoBehaviour
{
    [SerializeField] Retangulo retangulo;
    [SerializeField] Quadrado quadrado;
    [SerializeField] Circulo circulo;


    void Start()
    {
        Debug.Log(retangulo);
        Debug.Log(quadrado);
        Debug.Log(circulo);
    }

    void Update()
    {
        
    }
}
