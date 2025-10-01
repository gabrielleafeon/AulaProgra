using UnityEditor.SceneManagement;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    MeshRenderer meshRend;
    public Color cor = new Color();
    void Start()
    { 
        meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = new Color(1f, 1f, 1f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            meshRend.material.color = new Color(1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            meshRend.material.color = new Color(0f, 1f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            meshRend.material.color = new Color(0f, 0f, 1f);
        }
        meshRend.material.color = cor;  
    }
}
