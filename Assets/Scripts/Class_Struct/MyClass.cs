using UnityEngine;

public class MyClass
{
    public int myNumber;

    public MyClass(int num)
    {
        myNumber = num;
    }

    public void PrintNum()
    {
        Debug.Log("Class: " + myNumber);
    }
}
