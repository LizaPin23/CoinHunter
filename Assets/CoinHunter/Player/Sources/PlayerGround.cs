using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerGround : MonoBehaviour
    {
        public event Action<bool> GroundStateChanged;

        public bool Grounded { get; private set; }

        private List<Collider2D> _collidersInContact = new List<Collider2D>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _collidersInContact.Add(collision);

            if (_collidersInContact.Count == 1)
                SetGrounded(true);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            _collidersInContact.Remove(collision);

            if (_collidersInContact.Count == 0)
                SetGrounded(false);
        }

        private void SetGrounded(bool value)
        {
            Grounded = value;
            GroundStateChanged?.Invoke(value);
        }
    }
}

