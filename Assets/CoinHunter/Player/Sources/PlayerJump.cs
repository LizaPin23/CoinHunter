using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _jumpForce = 5f;

        private Vector2 jumpDirection => Vector2.up;

        public void Jump()
        {
            if (!enabled)
                return;

            _rigidbody.AddForce(jumpDirection * _jumpForce, ForceMode2D.Impulse);
        }
    }
}

