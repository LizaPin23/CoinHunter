
using UnityEngine;

namespace Homework.Animals
{
    public class Fox : IAnimal
    {
        public string Color => "Orange";

        public void MakePhoto()
        {
            Debug.Log("Сфотографировал лису");
        }
    }
}

