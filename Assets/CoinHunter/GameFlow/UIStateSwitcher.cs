using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class UIStateSwitcher : MonoBehaviour, IGameStateListener
    {
        [SerializeField] private UIMenu _uIMenuPause;
        [SerializeField] private UIMenu _uIMenuGameOver;
        [SerializeField] private UIMenu _uIMenuInGame;

        public void OnGameStateChanged(GameState value)
        {
            switch (value)
            {
                case GameState.Pause:
                    _uIMenuPause.SetActiveBool(true);
                    _uIMenuInGame.SetActiveBool(false);
                    _uIMenuGameOver.SetActiveBool(false);
                    return;

                case GameState.GameOver:
                    _uIMenuPause.SetActiveBool(false);
                    _uIMenuInGame.SetActiveBool(false);
                    _uIMenuGameOver.SetActiveBool(true);
                    return;

                case GameState.InGame:
                    _uIMenuPause.SetActiveBool(false);
                    _uIMenuInGame.SetActiveBool(true);
                    _uIMenuGameOver.SetActiveBool(false);
                    return;

            }
        }

        public void Switch()
        {

        }
    }
}

