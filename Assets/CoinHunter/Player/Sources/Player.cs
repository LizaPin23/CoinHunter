using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _movement;
        [SerializeField] private PlayerAnimator _animator;
        [SerializeField] private PlayerJump _jump;

        public void OnMovementKeyPressed(float movement)
        {
            _movement.Move(movement);
            _animator.Move();
        }
    }
}

