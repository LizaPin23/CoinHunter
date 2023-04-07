using UnityEngine;

namespace Homework.Providers
{
    public class ProviderCitiNet : IProvider
    {
        public int Speed { get; }

        public ProviderCitiNet(int speed)
        {
            Speed = speed;
        }

        public void Request()
        {
            Debug.Log("СитиНет отправляет запрос");
        }
    }
}
