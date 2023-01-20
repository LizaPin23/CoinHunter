using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGround : MonoBehaviour
{
    public bool Grounded { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Grounded = false;
    }
}
