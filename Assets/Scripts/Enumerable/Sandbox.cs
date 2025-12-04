using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AulaEnumerable
{
    public class Sandbox : MonoBehaviour, IEnumerable
    {
        void Start()
        {
            List<int> nums = new List<int> { 1, 2, 3 };

            //IEnumerator enumerator = nums.GetEnumerator();
            IEnumerator enumerator = GenerateNumEnumerator();
            StartCoroutine(enumerator);
         
        }

        IEnumerator GenerateNumEnumerator()
        {
            yield return 10;
            yield return new WaitForSeconds(2f);
            yield return 20;
            yield return 30;

        }


        public IEnumerator GetEnumerator()
        {
            yield return 10;
            yield return new WaitForSeconds(2f);
            yield return 20;
            yield return 30;
            Debug.Log("Terminei");
        }
    }
}
