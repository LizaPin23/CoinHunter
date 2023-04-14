
using UnityEngine;

namespace Homework.Animals
{
    public class Bear : IAnimal
    {
        public string Color => "Brown";
        
        public void MakePhoto()
        {
            Debug.Log("Сфотографировал медведя");
        }
    }
}

