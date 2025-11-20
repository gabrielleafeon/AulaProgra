using System;
using UnityEngine;

namespace PokemonAttack
{
    [CreateAssetMenu(fileName = "AttackData", menuName = "Pokémon/Attack")]
    public class AttackData : ScriptableObject
    {
        [SerializeField] protected string attackName;
        [SerializeField] protected Type type;
        [SerializeField] protected int basePower;
        [SerializeField] protected AttackCategory category;
        [SerializeField] protected int accuracy;
        [SerializeField] protected int currentPP;
        [SerializeField] protected int maxPP;
        [SerializeField] protected string effectDescription;


        public virtual void AttackEffect(Pokemon pokemon)
        {
            Debug.Log("dano");
        }

        public string AttackName
        {
            get => attackName;
            set
            {
                attackName = value;
            }
        }

        public Type Type
        {
            get => type;
            set
            {
                type = value;
            }
        }

        public int BasePower
        {
            get => basePower;
            set
            {
                basePower = Math.Abs(value);              
            }
        }

        public AttackCategory Category
        {
            get => category;
            private set
            {
                category = value;
            }
        }

        public int Accuracy
        {
            get => accuracy;
            set
            {
                accuracy = Mathf.Clamp(value, 0, 101);                
            }
        }

        public int CurrentPP
        {
            get => currentPP;
            set
            {
                currentPP = Mathf.Clamp(value, 0, maxPP);
            }
        }

        public int MaxPP
        {
            get => maxPP;
            set
            {
                maxPP = Mathf.Max(1, value);
            }
        }

        public string EffectDescription
        {
            get => effectDescription;
            private set
            {
                effectDescription = value;
            }
        }
    }
}

