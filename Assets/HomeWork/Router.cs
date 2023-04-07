using UnityEngine;

namespace Homework.Providers
{
    public class Router
    {
        private IProvider[] _providers;

        public Router(IProvider[] providers)
        {
            _providers = providers;
        }

        public void RequestFastestProvider()
        {
            int maxSpeed = 0;
            IProvider fastestProvider = null;
            
            for (int i = 0; i < _providers.Length; i++)
            {
                IProvider provider = _providers[i];

                if (provider.Speed > maxSpeed)
                {
                    maxSpeed = provider.Speed;
                    fastestProvider = provider;
                }
            }
            
            if (fastestProvider != null)
                fastestProvider.Request();
        }

        public void RequestAllProviders()
        {
            for (int i = 0; i < _providers.Length; i++)
            {
                _providers[i].Request();
            }
        }
    }
}


