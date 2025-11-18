using UnityEngine;

namespace SObject
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Weapon/Create New Weapon")]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] int damage;
        [SerializeField] int durability;

        public int Damage
        {
            get => damage;
            private set
            {
                damage = value;
            }
        }
    }
}
