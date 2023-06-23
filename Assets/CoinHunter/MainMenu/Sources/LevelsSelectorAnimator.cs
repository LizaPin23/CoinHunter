using UnityEngine;

namespace CoinHunter.MainMenu
{
    public class LevelsSelectorAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _visibleParam = "Visible";

        public void Show()
        {
            _animator.SetBool(_visibleParam, true);
        }

        public void Hide()
        {
            _animator.SetBool(_visibleParam, false);
        }
    }
}

