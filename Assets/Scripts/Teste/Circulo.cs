using System;
using UnityEngine;

[System.Serializable]
public class Circulo
{
    [SerializeField] float radius;

    public float Radius
    {
        get => radius;
        set
        {
            radius = Mathf.Abs(radius);
        }
    }

    public float Area
    {
        get => Mathf.Abs((float)Math.PI * radius * radius);
    }

    public override string ToString()
    {
        return ($"Sou um círculo de {Mathf.Abs(Radius)} de raio e tenho {Area} de área.");
    }

}
