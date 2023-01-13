using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _moveName = "MoveBool";
        [SerializeField] private string _jumpName = "JumpBool";


        public void Move(bool value)
        {
            _animator.SetBool(_moveName, value);
        }

        public void Jump(bool value)
        {
            _animator.SetBool(_jumpName, value);
        }
    }
}

