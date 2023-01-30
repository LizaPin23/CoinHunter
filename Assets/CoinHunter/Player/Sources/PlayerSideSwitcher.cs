using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerSideSwitcher : MonoBehaviour
    {
        [SerializeField] private Transform _view;

        public void ChooseSide(float movementX)
        {
            if (movementX >= 0)
                _view.localScale = new Vector3(1, 1, 1);

            else
                _view.localScale = new Vector3(-1, 1, 1);

        }
    }
}


