using System.Collections.Generic;
using UnityEngine;

namespace ListExercise
{

    public class CombatController : MonoBehaviour
    {
        public List<Player> players;
        public List<Enemy> enemies;

        void Start()
        {
            players = new List<Player>();
            enemies = new List<Enemy>();
        }

        void Update()
        {

        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

    }
}
