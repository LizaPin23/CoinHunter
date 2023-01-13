using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _stateParamName = "State";
        [SerializeField] private int _idleState = 0;
        [SerializeField] private int _moveState = 1;
        [SerializeField] private int _jumpState = 2;

        public void Move()
        {
            _animator.SetInteger(_stateParamName, _moveState);
        }

        public void Jump()
        {
            _animator.SetInteger(_stateParamName, _jumpState);
        }

        public void Idle()
        {
            _animator.SetInteger(_stateParamName, _idleState);
        }
    }
}

