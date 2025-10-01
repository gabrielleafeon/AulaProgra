using UnityEngine;

public class ArrayStruct : MonoBehaviour
{
    void Start()
    {
        MyStruct[] estruturas = new MyStruct[10];

        for (int i = 0; i < 10; i++)
        {
            MyStruct estrutura = new MyStruct(20);
            estruturas[i] = estrutura;
        }

        SetNumber(estruturas);
        estruturas[0].PrintNum();
    }

    public void SetNumber(MyStruct[] estruturas)
    {
        MyStruct mystruct = estruturas[0];
        mystruct.myNumber = 15;
    }
}
