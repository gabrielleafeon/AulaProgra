using UnityEngine;
using System.Collections.Generic;

public class Zoologico : MonoBehaviour
{
    List<Animal> animais;

    void Start()
    {
        //CriarZoologico();
        PrintAnimal();
    }

    private void CriarZoologico()
    {
        animais = new List<Animal>()
        {
            new Girafa("gi", 2), new Gato("ga"), new Girafa("gi2", 1.5f), new Pinguim(), new Gato("ga2"), new Cachorro("ca", 0.5f)
        };

        foreach (Animal animal in animais)
        {
            Debug.Log(animal.nome + " " + animal.numPatas);
        }
    }

    void PrintAnimal()
    {
        Animal animal = new Cachorro("Bono", 0.2f);
        animal = new Girafa("g", 1.5f);
        if (animal is Cachorro cachorro)
        {
            Debug.Log(cachorro.tamanhoOrelha);
        }
        else
        {
            Debug.Log("Não é um cachorro");
        }
    }
}
