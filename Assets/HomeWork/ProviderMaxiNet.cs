using UnityEngine;

namespace Homework.Providers
{
    public class ProviderMaxiNet : IProvider
    {
        public int Speed { get; }

        public ProviderMaxiNet(int speed)
        {
            Speed = speed;
        }

        public void Request()
        {
            Debug.Log("Запрос от МаксиНет");
        }
    }
}
