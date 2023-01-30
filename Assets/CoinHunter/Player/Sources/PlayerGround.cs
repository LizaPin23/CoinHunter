using System;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerGround : MonoBehaviour
    {
        public event Action<bool> GroundStateChanged;

        public bool Grounded { get; private set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Grounded = true;
            GroundStateChanged?.Invoke(true);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Grounded = false;
            GroundStateChanged?.Invoke(false);
        }
    }
}

