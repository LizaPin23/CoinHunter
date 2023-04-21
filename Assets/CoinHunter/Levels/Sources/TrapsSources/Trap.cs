using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Traps
{
    public class Trap : MonoBehaviour
    {
        [SerializeField] private int _uron = 1;
        [SerializeField] private Animator _animator;
        [SerializeField] private Collider2D _collider;

        public int Uron => _uron;



    }
}

