using UnityEngine;

namespace SObject
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] WeaponData weaponData;

        void Start()
        {
            Debug.Log(weaponData.Damage);
        }

        void Update()
        {
        
        }
    }
}
