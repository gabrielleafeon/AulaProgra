using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ExercicioID
{
    public class Sandbox : MonoBehaviour
    {
        public Identifiable<GameObject> obj;
        public Identifiable<Image> imageWithID;
        public Identifiable<int> num;
        public Identifiable<string> nameObj;

        public Lista<Color> arcoIris;

        void Start()
        {
            //imageWithID.PrintID();
            //obj.PrintID();
            //num.PrintID();
            //nameObj.PrintID();

            arcoIris = new Lista<Color>();

            arcoIris.AddItem(Color.azure);
            arcoIris.AddItem(Color.purple);
            arcoIris.AddItem(Color.red);
            arcoIris.AddItem(Color.yellow);
            arcoIris.AddItem(Color.orange);
            arcoIris.PrintAll();
        }

        void Update()
        {
        
        }
    }
}
