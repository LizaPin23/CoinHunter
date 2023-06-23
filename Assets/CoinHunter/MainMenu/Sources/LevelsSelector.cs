
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.MainMenu
{
    public class LevelsSelector : MonoBehaviour
    {
        [SerializeField] private LevelsSelectorAnimator _animator;
        [SerializeField] private Button _closeButton;
        [SerializeField] private LevelView _levelViewTemplate;
        [SerializeField] private Transform _levelViewContainer;

        private LevelsDatabase _database;
        private List<LevelView> _views = new List<LevelView>();

        public event Action<LevelData> LevelChosen;

        private void OnEnable()
        {
            _closeButton.onClick.AddListener(Hide);
        }
        
        private void OnDisable()
        {
            _closeButton.onClick.RemoveListener(Hide);
        }

        public void Initialize(LevelsDatabase database)
        {
            _database = database;

            foreach (var data in _database.LevelDatas)
            {
                LevelView view = Instantiate(_levelViewTemplate, _levelViewContainer);
                view.Initialize(data);
                view.Chosen += ViewOnChosen;
                _views.Add(view);
            }
        }

        public void Clear()
        {
            foreach (var view in _views)
            {
                view.Chosen -= ViewOnChosen;
            }
            
            _views.Clear();
        }

        private void ViewOnChosen(LevelData data)
        {
            LevelChosen?.Invoke(data);
        }

        public void Show()
        {
            _animator.Show();
        }

        public void Hide()
        {
            _animator.Hide();
        }
        
    }
}

