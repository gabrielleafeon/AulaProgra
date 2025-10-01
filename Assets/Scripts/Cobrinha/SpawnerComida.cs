using UnityEngine;

public class SpawnerComida : MonoBehaviour
{
    public GameObject prefabComida;
    public Fila cobrinha;


    void Start()
    {
        SpawnFood();
    }

    void Update()
    {
        if (this.transform.childCount == 0)
        {
            SpawnFood();
        }
    }

    public void SpawnFood()
    {
        Vector3 comidaTest = new Vector3(0, 0, 0);
        int safetyNumber = 0;
        bool foundValidPosition = false;
        while (!foundValidPosition || safetyNumber < 200)
        {
            comidaTest = new Vector3(-cobrinha.screenSizeX / 2 + cobrinha.distancia * Random.Range(0, (int)(cobrinha.screenSizeX / cobrinha.distancia)),
                                     -cobrinha.screenSizeY / 2 + cobrinha.distancia * Random.Range(0, (int)(cobrinha.screenSizeY / cobrinha.distancia)),
                                     0f);

            foreach (GameObject body in cobrinha.cobrinha)
            {
                if (comidaTest == body.transform.position)
                {
                    safetyNumber++;
                    foundValidPosition = false;
                    break;
                }
                else
                {
                    foundValidPosition = true;
                }
            }

        }

        if (foundValidPosition)
        {
            GameObject comida = Instantiate(prefabComida, this.transform);
            comida.transform.position = comidaTest;
        }
        else
        {
            Debug.Log("Sem espaço pra comida");
        }
    }
}
