using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using GameEssentials.GameManager;

public class GameWinLose : MonoBehaviour
{
    public int minigameID;

    public static GameWinLose Instance;

    public TextMeshProUGUI headerText;

    public int score;
    public float timeLeft;

    public GameObject[] gameObjectsToDisable;

    public Image badgeImage;
    public Sprite[] badgeSprites;


    public TextMeshProUGUI scoreText;

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

        if (score > 0 && timeLeft > 0)
        {
            badgeImage.gameObject.SetActive(true);
            badgeImage.sprite = badgeSprites[minigameID];
            headerText.text = "VICTORY!";
        }
        else if (score <= 0 || timeLeft <= 0)
        {
            headerText.text = "TRY AGAIN";
            badgeImage.sprite = badgeSprites[9];
        }

        scoreText.text = score.ToString("D4");

        Time.timeScale = 0.0f;
    }


    public void OnClick_TryAgainButton()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnClick_MainMenuButton()
    {
        GameManager.Instance.SaveData();

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}