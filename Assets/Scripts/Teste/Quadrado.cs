using UnityEngine;

[System.Serializable]
public class Quadrado
{
    [SerializeField] float length;
    public float Length
    {
        get => length;
        set
        {
            length = Mathf.Abs(value);
        }
    }

    public float Area
    {
        get => Mathf.Abs(Mathf.Pow(length, 2));
    }

    public override string ToString()
    {
        return ($"Sou um quadrado de {Mathf.Abs(Length)} de largura e tenho {Area} de área.");
    }
}
