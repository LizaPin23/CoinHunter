using UnityEngine;

namespace Homework.Providers
{
    public class ProvidersTest : MonoBehaviour
    {
        void Start()
        {
            IProvider telekom = new ProviderTelekom(5);
            IProvider cityNet = new ProviderCitiNet(10);
            IProvider maxiNet = new ProviderMaxiNet(20);

            IProvider[] providers = new[]
            {
                telekom, cityNet, maxiNet
            };
            
            Router router = new Router(providers);
            router.RequestAllProviders();
            router.RequestFastestProvider();
        }
        
    }
}

