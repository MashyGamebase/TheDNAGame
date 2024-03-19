using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public GameObject gameWinLose;

    public int score;
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI questText;
    public int currentQuest;
    public string currentQuestText;

    public string[] questString =
    {
        "You're body is heating up too quickly. Find a shade quickly so you don't overheat !",
        "You're in the heat quite a while, you're body is slowly getting thirsty",
        "Don't go in that hot spring, the water may seem tempting but it got hot because of the sun!"
    };

    public float delayBetweenCharacters = 0.1f;

    [Header("Timer Properties")]
    public float totalTime;
    private float currentTime;
    [SerializeField] private TextMeshProUGUI timerText;

    public static QuestManager Instance;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }


    private void Start()
    {
        questText.text = "";
        currentQuest = 0;

        // Account for game load so it starts exactly where you set it
        totalTime += 1;
        currentTime = totalTime;

        currentQuestText = questString[currentQuest];
        StartCoroutine(ShowText(questString[currentQuest]));
    }

    private void Update()
    {
        CountdownTimer();
        ScoreCounter();
    }

    void CountdownTimer()
    {
        currentTime -= Time.deltaTime;

        currentTime = Mathf.Clamp(currentTime, 0, totalTime);

        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


        if (currentTime <= 0f)
        {
            //Lose
            gameWinLose.SetActive(true);
            //Debug.Log("Timer Ran out!");
        }
    }

    void ScoreCounter()
    {
        scoreText.text = score.ToString("D4");
    }

    public void ResetQuest()
    {
        currentQuest = 0;
    }

    public void ProceedQuest(int currentQuestNum)
    {
        if(currentQuest == currentQuestNum)
        {
            if (currentQuest == 2)
            {
                gameWinLose.SetActive(true);
                return;
            }

            questText.text = "";

            if (currentQuest < 2)
                currentQuest += 1;
            else
                currentQuest = 0;

            currentQuestText = questString[currentQuest];

            StartCoroutine(ShowText(currentQuestText));
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (score <= 0)
            score = 0;
    }


    IEnumerator ShowText(string text)
    {
        for(int i = 0; i < text.Length; i++)
        {
            questText.text += text[i];
            yield return new WaitForSeconds(delayBetweenCharacters);
        }
    }
}