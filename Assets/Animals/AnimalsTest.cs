
using UnityEngine;

namespace Homework.Animals
{
    public class AnimalsTest : MonoBehaviour
    {
        void Start()
        {
            IAnimal bear = new Bear("коричневый");
            IAnimal fox = new Fox("рыжая");
            IAnimal wolf = new Wolf("серый");

            IAnimal[] animals = new[]
            {
                bear, fox, wolf
            };

            Photographer photographer = new Photographer(animals);
            photographer.TryMakePhotoAnimal();
            photographer.MakePhotoOrangeAnimal();
        }
    }
}

