
using UnityEngine;

namespace Homework.Animals
{
    public class AnimalsTest : MonoBehaviour
    {
        void Start()
        {
            IAnimal bear = new Bear();
            IAnimal fox = new Fox();
            IAnimal wolf = new Wolf();

            IAnimal[] animals = new[]
            {
                bear, fox, wolf
            };

            Photographer photographer = new Photographer(animals);
            photographer.TryMakePhotoAnimal();
            photographer.MakePhotoOrangeAnimal("Orange");
        }
    }
}

