using System;
using UnityEngine;

namespace Genericos
{
    [System.Serializable]
    public abstract class Animal : IComparable
    {
        public string nome;

        public Animal(string nome)
        {
            this.nome = nome;
        }

        public int CompareTo(object obj)
        {
            Animal otherAnimal = obj as Animal;
            if (otherAnimal != null)
            {
                return nome.CompareTo(otherAnimal.nome);
            }
            else
            {
                return nome.CompareTo(obj);
            }
                 
        }

        public override string ToString()
        {
            return $"({this.GetType().Name}) {nome}";
        }
    }
}
