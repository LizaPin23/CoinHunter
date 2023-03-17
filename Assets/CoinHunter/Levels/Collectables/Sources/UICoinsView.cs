using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class UICoinsView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void ShowCoins(int money)
        {
            _text.SetText(money.ToString());
        }
    }
}

