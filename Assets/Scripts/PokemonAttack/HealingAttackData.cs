using UnityEngine;

namespace PokemonAttack
{
    [CreateAssetMenu(fileName = "HealingAttackData", menuName = "Pokémon/HealingAttack")]
    public class HealingAttackData : AttackData
    {
        [SerializeField] string fala;
        public override void AttackEffect(Pokemon pokemon)
        {
            Debug.Log(fala);
        }
    }
}
