using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BotaoDesafio : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string fraseBotao = "Iniciar";
    public Slider slider;
    public GameObject cube;
    public Light spotLight;
    TextMeshProUGUI textPro;
    Button botao;
    Image fill;
    Image handle;
    MeshRenderer meshRend;
    void Start()
    {
        botao = GetComponent<Button>();
        //textPro = text.GetComponent<TextMeshProUGUI>();
        textPro = GetComponentInChildren<TextMeshProUGUI>();
        fill = slider.fillRect.GetComponent<Image>();
        handle = slider.handleRect.GetComponent<Image>();
        meshRend = cube.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        textPro.text = fraseBotao;

        Vector3 positionCube = cube.transform.position;
        positionCube.x = (slider.value - 0.5f) * 5;
        cube.transform.position = positionCube;

        Vector3 positionLight = spotLight.transform.position;
        positionLight.x = (slider.value - 0.5f) * 5;
        spotLight.transform.position = positionLight;


        Color fillColor = new Color(-(slider.value - 1f) * 0.5f, slider.value * 0.5f, 0);
        Color handleColor = new Color(-(slider.value - 1f), slider.value, 0);
        fill.color = fillColor;
        handle.color = handleColor;
        meshRend.material.color = fillColor;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            spotLight.intensity += 1f;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            spotLight.intensity -= 1f;
        }
    }

    public void MudarCorBotao()
    {
        if (textPro.color == new Color(0f, 0f, 0f))
        {
            textPro.color = new Color(1f, 1f, 1f);
            ColorBlock color = botao.colors;
            color.normalColor = new Color(1f, 0f, 0f);
            color.highlightedColor = new Color(1f, 0f, 0f);
            color.pressedColor = new Color(1f, 0f, 0f);
            color.selectedColor = new Color(1f, 0f, 0f);
            botao.colors = color;
            fraseBotao = "Voltar";
            textPro.text = fraseBotao;
        }
        else
        {
            textPro.color = new Color(0f, 0f, 0f);
            ColorBlock color = botao.colors;
            color.normalColor = new Color(1f, 1f, 1f);
            color.highlightedColor = new Color(1f, 1f, 1f);
            color.pressedColor = new Color(1f, 1f, 1f);
            color.selectedColor = new Color(1f, 1f, 1f);
            botao.colors = color;
            fraseBotao = "Iniciar";
            textPro.text = fraseBotao;
        }
    }
}
