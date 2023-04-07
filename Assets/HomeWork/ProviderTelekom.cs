using UnityEngine;

namespace Homework.Providers
{
    public class ProviderTelekom : IProvider
    {
        public int Speed { get; }

        public ProviderTelekom(int speed)
        {
            Speed = speed;
        }

        public void Request()
        {
            Debug.Log("Запрос провайдера телеком");
        }
    }
}

