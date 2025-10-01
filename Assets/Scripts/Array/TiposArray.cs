using UnityEngine;

public class TiposArray : MonoBehaviour
{
    public int[] numsInt;
    public float[] numsFloat;
    public string[] nomes = new string[10];
    public Vector3[] posicoes = new Vector3[10];
    void Start()
    {
        for(int i = 0; i < posicoes.Length; i++)
        {
            posicoes[i] = new Vector3(Random.Range(0f, 100f), Random.Range(0f, 100f), Random.Range(0f, 100f));
        }

        for (int i = 0; i < nomes.Length; i++)
        {
            for(int j = 0; j < Random.Range(1,6); j++)
            {
                nomes[i] += "a";
            }         
        }
    }

    void Update()
    {
        
    }
}
