using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class UIStateSwitcher : MonoBehaviour, IGameStateListener
    {
        [SerializeField] private int _windows;
        //временно инт
        // в зависимости от значения виндоус включает то или иное окошко
        // попробовавть создать лист с окошками чтобы добавлять окошки, но это не точно
        public void OnGameStateChanged(GameState value)
        {
            throw new System.NotImplementedException();
        }

        public void Perecluchenie()
        {

        }
    }
}

