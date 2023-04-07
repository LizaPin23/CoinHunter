using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class ProvaderTelekom : MonoBehaviour  //ISpeed
    {
        [SerializeField] private int _speed = 5;
        [SerializeField] private Router _router;

        private void Awake()
        {
            //_router.RequestRouter += Request;

        }

        private void Request(ProvaderEnum provader)
        {
            //пишет в консоль что нужно когда получает евент
        }
    }
}

