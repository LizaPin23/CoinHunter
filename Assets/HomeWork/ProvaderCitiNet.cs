using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class ProvaderCitiNet : MonoBehaviour  //ISpeed
    {
        [SerializeField] private int _speed = 5;
        [SerializeField] private Router _router;

        private void Awake()
        {
            //_router.RequestRouter += Request;

        }

        private void Request(ProvaderEnum provader)
        {
            //Debug.Log(); когда получает евент
        }
    }
}
