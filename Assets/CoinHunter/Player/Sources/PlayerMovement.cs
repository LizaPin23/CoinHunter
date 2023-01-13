using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        public void Move(float movement)
        {
            Vector2 moveVector = new Vector2(movement * _speed, 0);
            transform.Translate(moveVector * Time.deltaTime);
        }
    }
}

