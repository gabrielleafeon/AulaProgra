using UnityEngine;

namespace AulaDelegates
{
    public class Calculadora : MonoBehaviour
    {
        delegate float Operacao(float num1, float num2);
        public float num1;
        public float num2;

        void Start()
        {
            Calcular(num1, num2, Soma);
            Calcular(num1, num2, Subtracao);
            Calcular(num1, num2, Multiplicacao);
            Calcular(num1, num2, Divisao);
            Calcular(num1, num2, Exponencial);
        }

        void Update()
        {
        
        }

        float Calcular(float num1, float num2, Operacao op)
        {
            Debug.Log(op(num1, num2));
            return op(num1, num2);
        }

        float Soma(float num1, float num2)
        {
            return num1 + num2;
        }
        float Subtracao(float num1, float num2)
        {
            return num1 - num2;
        }
        float Multiplicacao(float num1, float num2)
        {
            return num1 * num2;
        }
        float Divisao(float num1, float num2)
        {
            return num1 / num2;
        }

        float Exponencial(float num1, float num2)
        {
            return Mathf.Pow(num1, num2);
        }
    }
}
