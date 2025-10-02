using UnityEngine;

namespace Static
{   
    public class Calculator
    {
        int count = 0;
        public static int totalOperations = 0;

        public static int Sum(int num1, int num2)
        {
            totalOperations += 1;
            int sum = num1 + num2;
            Debug.Log($"{num1} + {num2} = {sum}");
            return sum;            
        }

        public int SumInstance(int num1, int num2)
        {
            count += 1;
            return Sum(num1, num2);
        }
    }
}
