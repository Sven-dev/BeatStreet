using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        LevelManager.Instance.LoadLevel(2, Transition.Crossfade);
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
