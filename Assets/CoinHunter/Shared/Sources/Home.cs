using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _force = 3f;

    private Vector2 direction => Vector2.right;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnRButtonPressed();
        }
    }   
    
    public void OnRButtonPressed()
    {
        _rigidbody.AddForce(direction * _force, ForceMode2D.Impulse);
        Debug.Log("вызывается");
    }
}
