using System;
using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.Player
{
    public class Player : MonoBehaviour, IGameStateListener, IRestartListener, IGameOverInvoker 
    {
        [SerializeField] private PlayerMovement _movement;
        [SerializeField] private PlayerAnimator _animator;
        [SerializeField] private PlayerJump _jump;
        [SerializeField] private PlayerGround _ground;
        [SerializeField] private PlayerSideSwitcher _sideSwitcher;
        [SerializeField] private PlayerInteractive _interaction;
        
        private Vector3 _position;
        private bool _inGame;

        private void Awake()
        {
            _ground.GroundStateChanged += OnGroundStateChanged;
            _interaction.FallInWater += OnFallInWater;
        }

        private void OnFallInWater()
        {
            GameOver?.Invoke();
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
            transform.position = _position;
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

        public event Action GameOver;
    }
}

