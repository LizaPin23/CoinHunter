using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.MainMenu.FakeLevel
{
    public class FakeLevelBootstrap : MonoBehaviour
    {
        [SerializeField] private AIInput _input;
        [SerializeField] private Player.Player _player;
        [SerializeField] private Transform _playerPosition;

        private void Awake()
        {
            InitializeSystems();
            SubscribePlayer();
        }

        private void Start()
        {
            _player.OnGameStateChanged(GameState.InGame);
            _input.StartMovementRight();
        }

        private void InitializeSystems()
        {
            _player.Initialize(_playerPosition.position);
            _input.LevelEnded += _player.OnGameRestart;
        }

        private void SubscribePlayer()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.JumpInput += _player.OnJumpKeyPressed;
        }
    }
}

