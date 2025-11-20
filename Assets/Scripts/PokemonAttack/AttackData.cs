using System;
using UnityEngine;

namespace PokemonAttack
{
    [CreateAssetMenu(fileName = "AttackData", menuName = "Pokémon/Attack")]
    public class AttackData : ScriptableObject
    {
        [SerializeField] string attackName;
        [SerializeField] Type type;
        [SerializeField] int basePower;
        [SerializeField] AttackCategory category;
        [SerializeField] int accuracy;
        [SerializeField] int currentPP;
        [SerializeField] int maxPP;
        [SerializeField] string effectDescription;

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
                if(value <= 0)
                {
                    accuracy = 0;
                }
                else if(value <= 100)
                {
                    accuracy = value;
                }
                else if(value > 100)
                {
                    accuracy = 101;
                }
            }
        }

        public int CurrentPP
        {
            get => currentPP;
            set
            {
                if(value < 0)
                {
                    currentPP = 0;
                }
                else if(value <= maxPP)
                {
                    currentPP = value;
                }
                else if(value > maxPP)
                {
                    currentPP = maxPP;
                }
            }
        }

        public int MaxPP
        {
            get => maxPP;
            set
            {
                if(value < 1)
                {
                    maxPP = 1;
                }
                else
                {
                    maxPP = value;
                }
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

