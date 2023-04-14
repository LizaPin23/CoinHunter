
using UnityEngine;

namespace Homework.Animals
{
    public class Fox : IAnimal
    {
        public string Color { get; }

        public Fox(string color)
        {
            Color = color;
        }

        public void MakePhoto()
        {
            Debug.Log("Сфотографировал");
        }
    }
}

