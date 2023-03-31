using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        public void Move(float movement)
        {
            if (!enabled)
                return;
            
            Vector2 moveVector = new Vector2(movement * _speed, 0);
            transform.Translate(moveVector * Time.deltaTime);
        }
    }
}

