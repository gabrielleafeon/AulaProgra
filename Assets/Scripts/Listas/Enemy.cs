using NUnit.Framework;
using UnityEngine;
namespace ListExercise
{
    public class Enemy : MonoBehaviour
    {
        public bool isAlive;
        CombatController comCont;

        void Start()
        {
            isAlive = true;
            comCont = FindFirstObjectByType<CombatController>();
            comCont.AddEnemy(this);
        }

        void Update()
        {

        }

        void OnDestroy()
        {
            isAlive = false;
            comCont.RemoveEnemy(this);
        }
    }
}
