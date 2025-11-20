using UnityEngine;

namespace PokemonAttack
{
    [CreateAssetMenu(fileName = "ConfusionAttackData", menuName = "Pokémon/ConfusionAttack")]
    public class ConfusionAttackData : AttackData
    {
        [SerializeField] int chance;
        public override void AttackEffect(Pokemon pokemon)
        {
            if(chance <= Random.Range(0, 101))
            {
                Debug.Log("confusão");
            }
            else
            {
                Debug.Log("não confuso");
            }
            base.AttackEffect(pokemon);
        }
    }
}
