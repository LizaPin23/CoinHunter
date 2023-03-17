using CoinHunter.Levels.Collectables;
using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.Levels.Playground
{
    public class LevelsPlaygroundBootstrap : MonoBehaviour
    {
        [SerializeField] private KeyboardInputController _input;
        [SerializeField] private Player.Player _player;
        [SerializeField] private LevelCoins _coins;
        [SerializeField] private LevelHearts _hearts;

        private void Awake()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.SpacePressed += _player.OnJumpKeyPressed;
            _coins.Initialize();
            _hearts.Initialize();
        }
    }
}

