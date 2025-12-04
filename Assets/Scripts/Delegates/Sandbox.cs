using PlasticPipe.PlasticProtocol.Messages;
using System;
using UnityEngine;

namespace AulaDelegates
{
    public class Sandbox : MonoBehaviour
    {
        [SerializeField] GameObject player;
        [SerializeField] GameObject enemy;

        delegate void MyFunc(GameObject prefab);

        void Start()
        {
            CreateObject(player, PrintName);
            CreateObject(enemy, Move);
        }

        void CreateObject(GameObject prefab, MyFunc myFunc)
        {
            Debug.Log("Instanciei");
            myFunc(prefab);
        }

        void PrintName(GameObject prefab)
        {
            Debug.Log(prefab.name);
        }

        void Move(GameObject prefab)
        {
            Debug.Log("Mudei de posição");
            prefab.transform.position += new Vector3(1, 0, 0);
        }
    }
}
