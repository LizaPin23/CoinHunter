using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.Levels.Playground
{
    public class LevelsPlaygroundBootstrap : MonoBehaviour
    {
        [SerializeField] private KeyboardInputController _input;
        [SerializeField] private Player.Player _player;

        private void Awake()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.SpacePressed += _player.OnJumpKeyPressed;
        }
    }
}

