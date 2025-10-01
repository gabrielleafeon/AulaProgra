using UnityEngine;

public class TiposVariaveis : MonoBehaviour
{
    Vector3 pos;
    int num;
    void Start()
    {
        pos = new Vector3();
        pos.x = 10;
        gameObject.transform.position = pos;
    }

    void Update()
    {
        
    }
}
