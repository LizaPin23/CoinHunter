using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.MainMenu
{
    public class LevelView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private Image _preview;
        [SerializeField] private Button _button;

        public event Action<LevelData> Chosen;

        private LevelData _data;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }
        
        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            Chosen?.Invoke(_data);
        }

        public void Initialize(LevelData data)
        {
            _data = data;
            _nameText.SetText(data.LevelName);
            _preview.sprite = data.PrevSprite;
        }
    }

}
