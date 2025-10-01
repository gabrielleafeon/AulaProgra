using System.Collections.Generic;
using UnityEngine;

public class Zoologico2 : MonoBehaviour
{
    List<Animal> animais;

    void Start()
    {
        CriarZoologico();

    }

    private void CriarZoologico()
    {
        animais = new List<Animal>()
        {
            new Girafa("gi", 2), new Gato("ga"), new Pinguim(), new Cachorro("ca", 0.5f)
        };

        foreach (Animal animal in animais)
        {
            Debug.Log($"==========={animal.nome}===========");
            animal.FazerBarulho();
            animal.Nadar();
            animal.Emote();
        }
    }
}
