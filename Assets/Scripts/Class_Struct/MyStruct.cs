using UnityEngine;

public struct MyStruct
{
    public int myNumber;

    public MyStruct(int num)
    {
        myNumber = num;
    }

    public void PrintNum()
    {
        Debug.Log("Struct: " + myNumber);
    }
}
