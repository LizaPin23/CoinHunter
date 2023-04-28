using System;
using UnityEngine;

namespace CoinHunter.Levels.Interactive.Traps
{
    public class Traps : MonoBehaviour
    {
        [SerializeField] private Trap[] _traps;
        public event Action<int> GetInTraps;

        private void Initialized()
        {
            for (int i = 0; i < _traps.Length; i++)
            {
                Trap trap = _traps[i];
                // Ловушка не подписывается, поэтому (стр. 25)
                trap.GetInTrap += OnGetInTraps;
            }
        }

        private void OnGetInTraps(int _damage)
        {
            GetInTraps?.Invoke(_damage);
            Debug.Log("Привет");
            //Ивент из Трап отправляется, но тут не срабатывает
        }
    }
}

