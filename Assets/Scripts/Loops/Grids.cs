using Unity.VisualScripting;
using UnityEngine;

public class Grids : MonoBehaviour
{
    public GameObject cube;
    public int boardSize = 6;
    void Start()
    {
        bool gridColor = true;
        
        
        for (int x = 0; x <= boardSize; x++)
        {
            for (int y = 0; y <= boardSize; y++)
            {
                if(gridColor == true)
                {
                    Vector3 position = new Vector3(x, y, 0);
                    GameObject grid = Instantiate(cube, position, Quaternion.identity);
                    MeshRenderer cubeMesh;
                    cubeMesh = grid.GetComponent<MeshRenderer>();
                    cubeMesh.material.color = new Color(0, 0, 0);
                    gridColor = !gridColor;
                }
                else
                {
                    Vector3 position = new Vector3(x, y, 0);
                    GameObject grid = Instantiate(cube, position, Quaternion.identity);
                    MeshRenderer cubeMesh;
                    cubeMesh = grid.GetComponent<MeshRenderer>();
                    cubeMesh.material.color = new Color(1, 1, 1);
                    gridColor = !gridColor;
                }
                
            }
            if(boardSize % 2 == 1)
            {
                gridColor = !gridColor;
            }    
        }
    }
}
