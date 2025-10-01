using UnityEngine;

public class Loops : MonoBehaviour
{
    public int maxNum = 10;
    void Start()
    {
        //while (maxNum <= 10)
        //{            
        //    print(maxNum);
        //    maxNum += 1;
        //}

        //for(int i = 0; i <= 10; i++)
        //{
        //    print(i);
        //}

        //int currentNum = 0;
        int somaTotal = 0;

        //while (maxNum >= 0)
        //{
        //    currentNum = currentNum + maxNum;
        //    maxNum -= 1;            
        //}
        
        for(int i = 0; i <= maxNum; i++)
        {
            somaTotal = somaTotal + i;
            print(somaTotal);
        }

        print("Resposta: " + (somaTotal/(maxNum + 1f)));

    }

    void Update()
    {
        
    }
}
