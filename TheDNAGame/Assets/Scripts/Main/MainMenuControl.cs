using GameEssentials.GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void OnClick_Start(int whichLevelToLoad)
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.sceneToLoad = whichLevelToLoad;
    }

    public void OnClick_Options()
    {
        // might not be needed but only for sound options
    }

    public void OnClick_Quit()
    {
        // run a save data first before quitting
        Application.Quit();
    }
}