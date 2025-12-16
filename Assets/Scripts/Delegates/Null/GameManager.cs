using System.Collections.Generic;
using UnityEngine;

namespace AulaDelegates
{
    public class GameManager : MonoBehaviour
    {
        Spawner spawner;
        List<NPC> npcs;

        void Awake()
        {
            npcs = new List<NPC>();
            spawner = GetComponent<Spawner>();
            spawner.OnNPCSpawn += AddCreatedNPCtoList;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(npcs);
            }
        }

        void AddCreatedNPCtoList(NPC npc)
        {
            npcs.Add(npc);
        }
    }
}
