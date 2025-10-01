using UnityEngine;

public abstract class Animal
{
    public string nome;
    public int numPatas;
    protected string som;

    public Animal(string nome)
    {
        this.nome = nome;
        //Debug.Log("Criei um animal chamado: " + nome);
    }

    public Animal()
    {
        Debug.Log("Criei um animal sem nome :(");
    }

    public virtual void FazerBarulho() 
    {
        Debug.Log(som);
    }

    public abstract void Nadar();

    public abstract void Emote();
}


