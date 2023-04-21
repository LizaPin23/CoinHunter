using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Traps
{
    public class Trap : MonoBehaviour
    {
        [SerializeField] private int _damage = 1;
        [SerializeField] private Animator _animator;

        public int Damage => _damage;
        
        



    }
}

