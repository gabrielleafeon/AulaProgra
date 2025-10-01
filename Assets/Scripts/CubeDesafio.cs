using UnityEngine;

public class CubeDesafio : MonoBehaviour
{
    MeshRenderer meshRend;
    MeshFilter meshFilter;
    public Mesh mesh1;
    public Mesh mesh2;
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
        meshFilter = GetComponent<MeshFilter>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            meshFilter.mesh = mesh1;
            meshRend.material.SetFloat("_Metallic", 0f);
            meshRend.motionVectorGenerationMode = MotionVectorGenerationMode.Object;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            meshFilter.mesh = mesh2;
            meshRend.material.SetFloat("_Metallic", 1f);
            meshRend.motionVectorGenerationMode = MotionVectorGenerationMode.Camera;
        }
    }
}
