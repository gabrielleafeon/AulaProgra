using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PokemonAttack
{
    public class SpriteSetter : MonoBehaviour
    {
        [SerializeField] Sprite[] typeSprite;
        [SerializeField] Sprite[] categorySprite;
        [SerializeField] Image typeUI;
        [SerializeField] Image categoryUI;
        [SerializeField] TextMeshProUGUI attackName;
        [SerializeField] TextMeshProUGUI pp;
        [SerializeField] TextMeshProUGUI power;
        [SerializeField] TextMeshProUGUI accuracy;
        [SerializeField] TextMeshProUGUI description;

        public void SetSprites(AttackData attack)
        {
            typeUI.sprite = typeSprite[(int)attack.Type];
            categoryUI.sprite = categorySprite[(int)attack.Category];
            attackName.text = attack.AttackName;
            pp.text = ($"{attack.CurrentPP}/{attack.MaxPP}");
            description.text = attack.EffectDescription;

            if(attack.BasePower > 0)
            {
                power.text = ($"{attack.BasePower}");
            }
            else
            {
                power.text = "-";
            }

            if((attack.Accuracy > 0) && (attack.Accuracy < 101))
            {
                accuracy.text = ($"{attack.Accuracy}%");
            }
            else
            {
                accuracy.text = "-%";
            }
            
            
        }
    }
}
