using UnityEngine;

namespace PokemonAttack
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] AttackData attackData;
        [SerializeField] SpriteSetter spriteSetter;

        void Start()
        {
            spriteSetter.SetSprites(attackData);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spriteSetter.SetSprites(attackData);
            }
        }
    }
}

