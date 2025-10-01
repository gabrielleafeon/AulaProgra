using UnityEngine;

public class Cachorro : Animal
{
    public float tamanhoOrelha;
    public Cachorro(string nome, float tamanhoOrelha) : base(nome)
    {
        this.tamanhoOrelha = tamanhoOrelha;
        numPatas = 4;
        som = "Barulho de Cachorro";
    }

    public override void FazerBarulho()
    {
        base.FazerBarulho();
        base.FazerBarulho();
        base.FazerBarulho();
    }

    public override void Emote()
    {
        Debug.Log("૮₍ • ᴥ • ₎ა");
    }

    public override void Nadar()
    {
        Debug.Log("Nadar de cachorrinho");
    }
}
