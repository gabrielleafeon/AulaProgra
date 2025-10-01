using UnityEngine;

public class Gato : Animal
{
    int vidasRestantes;
    public Gato(string nome) : base(nome)
    {
        numPatas = 4;
        som = "Barulho de Gato";
        vidasRestantes = 7;
    }

    public override void FazerBarulho()
    {
        if(vidasRestantes < 4)
        {
            som = "Barulho de Gato Triste";
        }
        if(vidasRestantes > 0)
        {
            base.FazerBarulho();
        }    
    }

    public override void Emote()
    {
        Debug.Log(":3");
    }

    public override void Nadar()
    {
        Debug.Log("Recusar a entrar na água");
    }
}
