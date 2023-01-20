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
        [SerializeField] private PlayerGround _ground;

        public void OnMovementKeyPressed(float movement)
        {
            _movement.Move(movement);
            _animator.SetMoving(!Mathf.Approximately(movement, 0));
        }

        public void OnJumpKeyPressed()
        {
            if (_ground.Grounded)
            {
                _jump.Jump();
                _animator.SetOnAir(true);
            }
        }
    }
}

