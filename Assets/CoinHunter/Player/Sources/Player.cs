using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.Player
{
    public class Player : MonoBehaviour, IGameStateListener, IRestartListener 
    {
        [SerializeField] private PlayerMovement _movement;
        [SerializeField] private PlayerAnimator _animator;
        [SerializeField] private PlayerJump _jump;
        [SerializeField] private PlayerGround _ground;
        [SerializeField] private PlayerSideSwitcher _sideSwitcher;
        private Vector3 _position;
        private bool _inGame;

        private void Awake()
        {
            _ground.GroundStateChanged += OnGroundStateChanged;
        }

        public void Initialize(Vector3 startPosition)
        {
            _position = startPosition;

        }

        public void OnMovementKeyPressed(float movement)
        {
            if (_inGame == false)
                return;

            _movement.Move(movement);
            _sideSwitcher.ChooseSide(movement);
            _animator.SetMoving(!Mathf.Approximately(movement, 0));
        }

        public void OnJumpKeyPressed()
        {
            if (_inGame == false)
                return;

            if (_ground.Grounded)
            {
                _jump.Jump();
                _animator.SetOnAir(true);
            }
        }

        public void OnGameRestart()
        {
            Debug.Log(_position);
        }

        public void OnDamage()
        {
            if (_inGame == false)
                return;

            _animator.PlayDamage();
        }

        private void OnGroundStateChanged(bool value)
        {
            _animator.SetOnAir(!value);
        }

        public void OnGameStateChanged(GameState value)
        {
            _inGame = value == GameState.InGame;
        }

    }
}

