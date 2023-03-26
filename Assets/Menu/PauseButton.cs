using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public event Action Pressed;

    public void SetVisible(bool sth)
    {
        gameObject.SetActive(sth);
    }

    public void OnPress()
    {
        Pressed?.Invoke();
    }
}
