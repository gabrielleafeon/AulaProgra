using System.Drawing;
using UnityEngine;

public class Coin : MonoBehaviour
{
    MeshRenderer meshRend;
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = new UnityEngine.Color(1f, 0.8f, 0f);
    }

}
