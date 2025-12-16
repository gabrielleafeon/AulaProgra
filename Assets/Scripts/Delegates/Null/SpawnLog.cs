using UnityEngine;

namespace AulaDelegates
{
    public class SpawnLog : MonoBehaviour
    {
        Spawner spawner;

        void Start()
        {
            spawner = GetComponent<Spawner>();
            spawner.OnNPCSpawn += NPCSpawnLog;
        }

        void Update()
        {
        
        }

        void NPCSpawnLog(NPC npc)
        {
            Debug.Log(npc.name);
        }
    }
}
