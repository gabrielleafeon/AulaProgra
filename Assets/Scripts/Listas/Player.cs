using UnityEngine;
namespace ListExercise
{

    public class Player : MonoBehaviour
    {
        public bool isAlive;
        CombatController comCont;

        void Start()
        {
            isAlive = true;
            comCont = FindFirstObjectByType<CombatController>();
            comCont.AddPlayer(this);
        }

        void Update()
        {

        }

        void OnDestroy()
        {
            isAlive = false;
            comCont.RemovePlayer(this);
        }
    }
}
