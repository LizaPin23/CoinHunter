using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public event Action QuitButtonPressed;
    public event Action ContinueButtonPressed;

    private void Awake()
    {
        SetVisible(false);
    }

    public void SetVisible(bool sth)
    {
        gameObject.SetActive(sth);
    }

    public void OnQuitButtonPressed()
    {
        QuitButtonPressed?.Invoke();
    }

    public void OnContinueButtonPressed()
    {
        ContinueButtonPressed?.Invoke();
    }
}
