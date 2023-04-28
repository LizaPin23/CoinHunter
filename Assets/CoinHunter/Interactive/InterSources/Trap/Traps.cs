using System;
using UnityEngine;

namespace CoinHunter.Levels.Interactive.Traps
{
    public class Traps : MonoBehaviour
    {
        [SerializeField] private Trap[] _traps;
        public event Action<int> GetInTraps;

        public void Initialize()
        {
            for (int i = 0; i < _traps.Length; i++)
            {
                Trap trap = _traps[i];
                trap.GetInTrap += OnGetInTraps;
            }
        }

        private void OnGetInTraps(int _damage)
        {
            GetInTraps?.Invoke(_damage);
        }
    }
}

