using UnityEngine;
using UnityEngine.Timeline;

public class ClassStruct : MonoBehaviour
{
    void Start()
    {
        MyClass classe = new MyClass(20);
        MyStruct estrutura = new MyStruct(20);
        //ChangeNumber(classe, estrutura, 15);
        SetNumber(classe, estrutura, 15);
        classe.PrintNum();
        estrutura.PrintNum();
    }

    void ChangeNumber(MyClass classe, MyStruct extrutura, int num)
    {
        classe.myNumber = num;
        extrutura.myNumber = num;
    }

    void SetNumber(MyClass classe, MyStruct extrutura, int num)
    {
        classe = new MyClass(num);
        extrutura = new MyStruct(num);
    }
}
