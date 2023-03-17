using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class Heart : MonoBehaviour, ICollectable
    {
        [SerializeField] private int _value = 1;
        [SerializeField] private Animator _animator;
        [SerializeField] private string _visibleParam;
        [SerializeField] private Collider2D _collider;

        public event Action<int> Collected;

        public void Collect()
        {
            Collected?.Invoke(_value);
            Hide();
        }

        public void Show()
        {
            _animator.SetBool(_visibleParam, true);
            _collider.enabled = true;
        }

        public void Hide()
        {
            _animator.SetBool(_visibleParam, false);
            _collider.enabled = false;
        }
    }
}
