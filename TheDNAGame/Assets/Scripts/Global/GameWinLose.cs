using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameWinLose : MonoBehaviour
{
    public static GameWinLose Instance;

    public GameObject[] gameObjectsToDisable;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameScore;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    public void OnEnable()
    {
        OnGamePreExit();
    }

    public void OnGamePreExit()
    {
        foreach(GameObject go in gameObjectsToDisable)
        {
            go.SetActive(false);
        }

        scoreText.text = gameScore.text;

        Time.timeScale = 0.0f;
    }


    public void OnClick_TryAgainButton()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnClick_MainMenuButton()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}