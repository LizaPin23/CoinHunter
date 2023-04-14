
using UnityEngine;

namespace Homework.Animals
{
    public class Bear : IAnimal
    {
        public string Color { get; }

        public Bear(string color)
        {
            Color = color;
        }

        public void MakePhoto()
        {
            Debug.Log("Сфотографировал");
        }
    }
}

