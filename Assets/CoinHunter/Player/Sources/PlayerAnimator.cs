﻿using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _movingBool = "Moving";
        [SerializeField] private string _airBool = "OnAir";
        [SerializeField] private string _trapTrigger = "Trap";


        public void SetOnAir(bool value)
        {
            
            _animator.SetBool(_airBool, value);
        }

        public void SetMoving(bool value)
        {
            _animator.SetBool(_movingBool, value);
        }

        public void PlayDamage()
        {
            _animator.SetTrigger(_trapTrigger);
        }
    }
}

