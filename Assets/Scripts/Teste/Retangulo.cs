using UnityEngine;

[System.Serializable]
public class Retangulo
{
    [SerializeField] float height;
    [SerializeField] float width;
    public float Height
    {
        get => height;
        set
        {
            height = Mathf.Abs(value);
        }
    }
    public float Width
    {
        get => width;
        set
        {
            width = Mathf.Abs(value);
        }
    }

    public float Area
    {
        get
        {
            return Mathf.Abs(Height * Width);
        }
    }

    public override string ToString()
    {
        return ($"Sou um retângulo de {Mathf.Abs(Width)} de largura, {Mathf.Abs(Height)} de altura e tenho {Area} de área.");
    }
}
