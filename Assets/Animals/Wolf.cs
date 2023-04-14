
using UnityEngine;

namespace Homework.Animals
{
    public class Wolf : IAnimal
    {
        public string Color => "Grey";
        
        public void MakePhoto()
        {
            Debug.Log("Сфотографировал волка");
        }
    }
}


