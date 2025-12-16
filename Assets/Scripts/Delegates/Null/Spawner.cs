using System;
using UnityEngine;

namespace AulaDelegates
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] float timer;
        [SerializeField] NPC npcPrefab;
        float timeToSpawn;
        public Action<NPC> OnNPCSpawn;
        int npcNumber = 0;

        void Start()
        {
            
        }

        void Update()
        {
            timeToSpawn += Time.deltaTime;

            if(timeToSpawn >= timer)
            {
                timeToSpawn = 0;

                NPC npc = Instantiate(npcPrefab, new Vector3(npcNumber, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                npcNumber += 1;

                npc.name = $"{npcNumber.ToString("D3")} - [{Time.frameCount}]";
                OnNPCSpawn(npc);                
            }
        }
    }
}
