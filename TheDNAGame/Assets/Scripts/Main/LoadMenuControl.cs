using GameEssentials.GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAndSwitchScenes(GameManager.Instance.sceneToLoad));
        // Prepare
    }

    IEnumerator LoadAndSwitchScenes(int sceneToLoad)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);

        while(!asyncLoad.isDone)
        {
            // if there is a loading bar, you can update it here

            yield return null;
        }


        // sceneLoaded = true;
    }
}