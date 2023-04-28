
using System;
using UnityEngine;

namespace CoinHunter.Levels.Interactive.Traps 
{
    public class Trap : MonoBehaviour, ITrap 
    {
        [SerializeField] private int _damage = 1;
        [SerializeField] private Animator _animator;
        [SerializeField] private string _triggerParam = "SpikeTrigger";
        public event Action<int> GetInTrap;


        public int Damage => _damage;

        public void Activate()
        {
            GetInTrap?.Invoke(_damage);
            _animator.SetTrigger(_triggerParam);
        }
    }
}

