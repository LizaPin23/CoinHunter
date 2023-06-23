using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class UIStateSwitcher : MonoBehaviour, IGameStateListener
    {
        [SerializeField] private UIMenu _uIMenuPause;
        [SerializeField] private UIMenu _uIMenuGameOver;
        [SerializeField] private UIMenu _uIMenuInGame;
        [SerializeField] private UIMenu _uIMenuFinish;


        public void OnGameStateChanged(GameState value)
        {
            switch (value)
            {
                case GameState.Pause:
                    _uIMenuPause.SetActiveBool(true);
                    _uIMenuInGame.SetActiveBool(false);
                    _uIMenuGameOver.SetActiveBool(false);
                    _uIMenuFinish.SetActiveBool(false);
                    return;

                case GameState.GameOver:
                    _uIMenuPause.SetActiveBool(false);
                    _uIMenuInGame.SetActiveBool(false);
                    _uIMenuGameOver.SetActiveBool(true);
                    _uIMenuFinish.SetActiveBool(false);
                    return;

                case GameState.InGame:
                    _uIMenuPause.SetActiveBool(false);
                    _uIMenuInGame.SetActiveBool(true);
                    _uIMenuGameOver.SetActiveBool(false);
                    _uIMenuFinish.SetActiveBool(false);
                    return;
                
                case GameState.Finish:
                    _uIMenuPause.SetActiveBool(false);
                    _uIMenuInGame.SetActiveBool(false);
                    _uIMenuGameOver.SetActiveBool(false);
                    _uIMenuFinish.SetActiveBool(true);
                    return;
            }
        }
    }
}

