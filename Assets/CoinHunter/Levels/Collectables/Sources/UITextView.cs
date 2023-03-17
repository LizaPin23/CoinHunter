using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class UITextView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void ShowValue(int value)
        {
            _text.SetText(value.ToString());
        }
    }
}

