﻿using System.Collections;
using System.Collections.Generic;
using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerPlaygroundBootstrap : MonoBehaviour
    {
        [SerializeField] private KeyboardInputController _input;
        [SerializeField] private Player _player;

        private void Awake()
        {
            _input.Movement += _player.OnMovementKeyPressed;
        }
    }
}

