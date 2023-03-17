using System;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class ButtonBlock : MonoBehaviour, IWaterReaction, IButtonPress
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        private Vector3 _startPosition;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        public void ReactWater()
        {
            _rigidbody.velocity = Vector2.zero;
            transform.position = _startPosition;
        }

    }
}
