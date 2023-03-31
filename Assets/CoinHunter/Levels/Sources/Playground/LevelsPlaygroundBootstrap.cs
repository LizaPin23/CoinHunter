using CoinHunter.GameFlow;
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
        [SerializeField] private UIStateSwitcher _uiStateSwitcher;

        private GameFlowController _gameFlowController;

        private void Awake()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.SpacePressed += _player.OnJumpKeyPressed;

            _coins.Initialize();
            _hearts.Initialize();

            _gameFlowController = new GameFlowController()
        }

        private IGameStateListener[] StateListener()
        {

        }


        
    }
}

