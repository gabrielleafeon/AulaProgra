using UnityEngine;

namespace Interface
{
    public class ColorManager : MonoBehaviour
    {

        private void Start()
        {
            foreach (var colorizable in GetComponentsInChildren<IColorizable>())
            {
                colorizable.ChangeColor(Color.blue);              
            }
        }
    }
}
