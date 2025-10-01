using UnityEngine;

public class ArrayClass : MonoBehaviour
{
    
    void Start()
    {
        MyClass[] classes = new MyClass[10];

        for (int i = 0; i < 10; i++)
        {
            MyClass classe = new MyClass(20);
            classes[i] = classe;
        }

        SetNumber(classes);
        classes[0].PrintNum();
    }

    public void SetNumber(MyClass[] classes)
    {
        MyClass myclass = classes[0];
        myclass.myNumber = 15;
    }
}
