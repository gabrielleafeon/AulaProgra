using UnityEngine;

public class Pinguim : Animal
{
    public Pinguim() : base("Roger")
    {
        numPatas = 2;
        som = "Barulho de Pinguim";
    }

    public override void FazerBarulho()
    {
        base.FazerBarulho();
        som += " Piu";
        base.FazerBarulho();
    }

    public override void Emote()
    {
        Debug.Log("OvO");
    }

    public override void Nadar()
    {
        Debug.Log("Bater asas");
    }
}
