using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pilha : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text text;
    public Button undoButton;
    public Button doButton;
    Stack<string> stack;
    Stack<string> undos;
    public KeyCode keycode;

    void Start()
    {
        stack = new Stack<string>();
        undos = new Stack<string>();
        undoButton.interactable = false;
        doButton.interactable = false;
    }

    void Update()
    {
        if (IsPressingCtrl() && Input.GetKeyDown(keycode) && IsPressingShift())
        {
            DoName();
        }
        else if (IsPressingCtrl() && Input.GetKeyDown(keycode))
        {
            UndoName();
        }        
    }

    public void ApplyName()
    {
        string name = inputField.text;
        stack.Push(name);
        undos.Clear();
        UpdateButtons();
        UpdateText();
    }

    public void UndoName()
    {
        if (stack.Count > 0)
        {
            string lastName = stack.Pop();
            undos.Push(lastName);
        }

        UpdateButtons();
        UpdateText();

    }

    public void DoName()
    {
        if (undos.Count > 0)
        {
            stack.Push(undos.Pop());
            UpdateButtons();
            UpdateText();
        }

    }

    private void UpdateText()
    {
        if (stack.Count > 0)
        {
            text.text = stack.Peek();
        }
        else
        {
            text.text = "";
        }
    }

    private void UpdateButtons()
    {
        if (undos.Count <= 0)
        {
            doButton.interactable = false;
        }
        else
        {
            doButton.interactable = true;
        }

        if (stack.Count <= 0)
        {
            undoButton.interactable = false;
        }
        else
        {
            undoButton.interactable = true;
        }
    }

    private bool IsPressingCtrl()
    {
        return Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
    }

    private bool IsPressingShift()
    {
        return Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
    }
}
