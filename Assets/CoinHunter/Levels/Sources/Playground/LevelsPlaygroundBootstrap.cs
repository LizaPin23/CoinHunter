﻿using System.Collections.Generic;
using CoinHunter.GameFlow;
using CoinHunter.Levels.Collectables;
using CoinHunter.Levels.Interactive;
using CoinHunter.Levels.Interactive.Traps;
using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.Levels
{
    public class LevelsPlaygroundBootstrap : MonoBehaviour
    {
        [Header("Services references")] 
        [SerializeField] private KeyboardInputController _input;
        [SerializeField] private LevelSaver _levelSaver;
        [SerializeField] private LevelLoader _levelLoader;

        [Header("Level references")] 
        [SerializeField] private LevelCoins _coins;
        [SerializeField] private LevelHearts _hearts;
        [SerializeField] private Traps _traps;
        [SerializeField] private LevelEndDoor _endDoor;
        
        [Header("Player references")]
        [SerializeField] private Player.Player _player;
        [SerializeField] private Transform _playerPosition;
        [SerializeField] private CameraFollower _camera;

        [Header("UI references")] 
        [SerializeField] private UITextView _coinsView;
        [SerializeField] private UITextView _heartsView;
        [SerializeField] private UIStateSwitcher _uiStateSwitcher;
        [SerializeField] private LevelUI _levelUI;

        private GameFlowController _gameFlowController;

        private void Awake()
        {
            InitializeSystems();
            
            IGameStateListener[] gameStateListeners = CreateGameStateListeners();
            IRestartListener[] restartListeners = CreateRestartListeners();

            IPauseInvoker[] pauseInvokers = CreatePauseInvokers();
            IRestartInvoker[] restartInvokers = CreateRestartInvokers();
            IContinueInvoker[] continueInvokers = CreateContinueInvokers();
            IGameOverInvoker[] gameOverInvokers = CreateGameOverInvokers();
            IFinishInvoker[] finishInvokers = CreateFinishInvokers();
            
            ISaveInvoker[] saveInvokers = CreateSaveInvokers();

            foreach (var saveInvoker in saveInvokers)
            {
                saveInvoker.SaveLevel += _levelSaver.Save;
            }
            
            IQuitInvoker[] quitInvokers = CreateQuitInvokers();
            
            foreach (var quitInvoker in quitInvokers)
            {
                quitInvoker.Quit += _levelLoader.LoadMainMenu;
            }

            _gameFlowController = new GameFlowController(gameStateListeners, pauseInvokers, gameOverInvokers, 
                continueInvokers, restartInvokers, restartListeners, finishInvokers);

            _levelUI.NextLevelLoad += _levelLoader.LoadNextLevel;

            _traps.GetInTraps += _hearts.OnHeartConsumed;
            
            SubscribePlayer();
        }

        private void Start()
        {
            _gameFlowController.OnRestart();
        }

        private void InitializeSystems()
        { 
            _coins.Initialize(_coinsView);
            _hearts.Initialize(_heartsView);
            _traps.Initialize();
            _player.Initialize(_playerPosition.position);
            _camera.Initialize(_player.transform);
        }

        private void SubscribePlayer()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.SpacePressed += _player.OnJumpKeyPressed;
            _hearts.HeartConsumed += _player.OnDamage;
        }

        private IGameStateListener[] CreateGameStateListeners()
        {
            List<IGameStateListener> result = new List<IGameStateListener>();
            result.Add(_uiStateSwitcher);
            result.Add(_player);

            return result.ToArray();
        }

        private IRestartListener[] CreateRestartListeners()
        {
            List<IRestartListener> result = new List<IRestartListener>();
            result.Add(_coins);
            result.Add(_hearts);
            result.Add(_player);

            return result.ToArray();
        }

        private IPauseInvoker[] CreatePauseInvokers()
        {
            IPauseInvoker[] result = new[]
            {
                _input
            };

            return result;
        }
        
        private ISaveInvoker[] CreateSaveInvokers()
        {
            ISaveInvoker[] result = new[]
            {
                _levelUI
            };

            return result;
        }

        private IRestartInvoker[] CreateRestartInvokers()
        {
            IRestartInvoker[] result = new[]
            {
                _levelUI
            };

            return result;
        }

        private IGameOverInvoker[] CreateGameOverInvokers()
        {
            IGameOverInvoker player = _player;
            IGameOverInvoker[] result = new[]
            {
                _hearts,
                player
            };

            return result;
        }

        private IQuitInvoker[] CreateQuitInvokers()
        {
            IQuitInvoker[] result = new[]
            {
                _levelUI
            };

            return result;
        }

        private IContinueInvoker[] CreateContinueInvokers()
        {
            IContinueInvoker[] result = new[]
            {
                _levelUI
            };

            return result;
        }

        private IFinishInvoker[] CreateFinishInvokers()
        {
            IFinishInvoker[] result = new[]
            {
                _endDoor
            };

            return result;
        }
    }
}


