using System;
using UnityEngine;

namespace CoinHunter.Levels.Interactive.Traps
{
    public class Traps : MonoBehaviour
    {
        private Trap[] _traps;
        public event Action<int> GetInTraps;

        public void Initialize()
        {
            _traps = GetComponentsInChildren<Trap>();
            
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

