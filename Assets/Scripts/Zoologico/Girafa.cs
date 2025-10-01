using UnityEngine;

public class Girafa : Animal
{
    float tamanhoPescoco;
    public Girafa(string nome, float tamanhoPescoco) : base(nome)
    {
        numPatas = 4;
        som = "Barulho de Girafa";
        this.tamanhoPescoco = tamanhoPescoco;
    }


    public override void FazerBarulho()
    {
        
    }
    public override void Emote()
    {
        Debug.Log(":)");
    }

    public override void Nadar()
    {
        Debug.Log("Afogou");
    }
}
