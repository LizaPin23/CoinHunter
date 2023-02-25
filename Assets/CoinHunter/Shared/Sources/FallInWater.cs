using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using CoinHunter.Player;


public class FallInWater : MonoBehaviour
{
    public event Action GameOver;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            Debug.Log("GameOver");
            GameOver?.Invoke();
        }
    }
}
