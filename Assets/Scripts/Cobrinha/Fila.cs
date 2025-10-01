using System.Collections.Generic;
using UnityEngine;

public class Fila : MonoBehaviour
{
    public GameObject prefabCorpo;
    public Queue<GameObject> cobrinha;
    public float distancia = 1.5f;
    public float screenSizeX = 18;
    public float screenSizeY = 9;
    public int tamanhoInicial = 3;
    Vector3 direcao;
    Vector3 cabeca;

    void Start()
    {
        cobrinha = new Queue<GameObject>();
        cabeca = this.transform.position;
        direcao = new Vector3(distancia, 0, 0);
        AddBody(tamanhoInicial);

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            direcao = new Vector3(distancia, 0, 0);
            MoveBody(direcao);  
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direcao = new Vector3(-distancia, 0, 0);
            MoveBody(direcao);  
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direcao = new Vector3(0, distancia, 0);
            MoveBody(direcao);           
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direcao = new Vector3(0, -distancia, 0);
            MoveBody(direcao);    
        }
    }

    public void AddBody(int x)
    {
        for(int i = 0; i < x; i++)
        {
            GameObject newBody = Instantiate(prefabCorpo, this.transform);
            newBody.transform.position = cabeca;
            newBody.transform.position = CheckIfHitWall(newBody.transform.position);
            cobrinha.Enqueue(newBody);
            cabeca = newBody.transform.position;
        }      
    }

    public void MoveBody(Vector3 direcao)
    {
        GameObject body = cobrinha.Dequeue();
        body.transform.position = cabeca + direcao;
        body.transform.position = CheckIfHitWall(body.transform.position);
        cabeca = body.transform.position;
        cobrinha.Enqueue(body);
    }

    public Vector3 CheckIfHitWall(Vector3 position)
    {
        if(position.x > screenSizeX / 2)
        {
            position.x = -screenSizeX / 2;
        }
        if (position.x < -screenSizeX / 2)
        {
            position.x = screenSizeX / 2;
        }

        if (position.y > screenSizeY / 2)
        {
            position.y = -screenSizeY / 2;
        }
        if (position.y < -screenSizeY / 2)
        {
            position.y = screenSizeY / 2;
        }

        return position;
    }

}
