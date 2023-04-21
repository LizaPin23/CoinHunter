namespace Homework.Animals
{
    public class Photographer
    {
        private IAnimal[] _animals;

        public Photographer(IAnimal[] animals)
        {
            _animals = animals;
        }

        public void TryMakePhotoAnimal()
        {
            for (int i = 0; i < _animals.Length; i++)
            {
                _animals[i].MakePhoto();
            }
        }

        public void MakePhotoOrangeAnimal(string color)
        {
            for (int i = 0; i < _animals.Length; i++)
            {
                if (_animals[i].Color == color)
                {
                    _animals[i].MakePhoto();
                }
            }
        }
    }
}

