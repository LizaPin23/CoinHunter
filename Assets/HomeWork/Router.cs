using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class Router : MonoBehaviour
{
    public event Action RequestRouter;
    void Start()
    {
        RequestRouter?.Invoke();
    }
}
