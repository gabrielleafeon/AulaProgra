using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dicionario : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField numberInput;
    Dictionary<string, string> telefones;

    void Start()
    {
        telefones = new Dictionary<string, string>();
    }

    void Update()
    {
        
    }

    public void AddNumber()
    {
        if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrEmpty(numberInput.text))
        {
            return;
        }
        telefones[nameInput.text] = numberInput.text;
        nameInput.text = null;
        numberInput.text = null;
    }

    public void RemoveNumber()
    {
        if (string.IsNullOrEmpty(nameInput.text))
        {
            return;
        }
        telefones.Remove(nameInput.text);
        nameInput.text = null;
    }

    public void ConsultNumber()
    {
        if (telefones.ContainsKey(nameInput.text))
        {
            numberInput.text = telefones[nameInput.text];
        }
    }

    public void PrintNumbers()
    {
        foreach(var contato in telefones)
        {
            Debug.Log($"Nome: {contato.Key} Telefone: {contato.Value}");
        }
    }
}
