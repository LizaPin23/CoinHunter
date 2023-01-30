using UnityEngine;

namespace CoinHunter.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _movement;
        [SerializeField] private PlayerAnimator _animator;
        [SerializeField] private PlayerJump _jump;
        [SerializeField] private PlayerGround _ground;
        [SerializeField] private PlayerSideSwitcher _sideSwitcher;

        private void Awake()
        {
            _ground.GroundStateChanged += OnGroundStateChanged;
        }

        public void OnMovementKeyPressed(float movement)
        {
            _movement.Move(movement);
            _sideSwitcher.ChooseSide(movement);
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

        private void OnGroundStateChanged(bool value)
        {
            _animator.SetOnAir(!value);
        }
    }
}

