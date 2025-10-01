using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    Slider lifebar;
    TextMeshProUGUI text;

    void Start()
    {
        lifebar = GetComponent<Slider>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    public void LifeChange(int life)
    {
        lifebar.value = life / 100f;
        text.text = life.ToString();
    }
}
