
using UnityEngine;

namespace Homework.Animals
{
    public class Wolf : IAnimal
    {
        public string Color { get; }

        public Wolf(string color)
        {
            Color = color;
        }

        public void MakePhoto()
        {
            Debug.Log("Сфотографировал");
        }
    }
}


