using UnityEngine;

public class Array : MonoBehaviour
{
    int[] nums;


    void Start()
    {
        
        nums = new int[10];
        PrintArray(nums);
    }

    void Update()
    {
        
    }

    void PrintArray(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++) 
        {
            print(nums[i]);
        }
    }
}
