using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public int[] nums = new int[50];
    void Start()
    {
        //for(int i = 0; i < 50; i++)
        //{
        //    int x = Random.Range(0, 10); //Max exclusive
        //    print(x);
        //}

        //for (int i = 0; i < 50; i++)
        //{
        //    float x = Random.Range(0f, 10f); //Max inclusive
        //    print(x);
        //}

        

        PreencherArray(nums);
        MenorMaiorArray(nums);
    }

    void Update()
    {
        
    }

    void PreencherArray(int[] arr)
    {

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(0, 1000);
            //print(arr[i]);
        }
    }

    void MenorMaiorArray(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Debug.Log("Array nula");
            return;   
        }

        int maxNum = arr[0];
        int minNum = arr[0];

        //int maxNum = int.MinValue;
        //int minNum = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxNum)
            {
                maxNum = arr[i];
            }

            if (arr[i] < minNum)
            {
                minNum = arr[i];
            }
        }

        print($"Max: {maxNum} e Min: {minNum}");
    }
}
