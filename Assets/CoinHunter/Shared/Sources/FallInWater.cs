using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class FallInWater : MonoBehaviour
{
    public event Action GameOver;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            GameOver?.Invoke();
        }
    }
}
