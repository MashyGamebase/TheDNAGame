using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestionIdentifier
{
    Right,
    Wrong
}

public class QuestTrigger : MonoBehaviour
{
    public int questTrigger;
    public GameObject popup;
    public int score;
    public QuestionIdentifier identifier;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (identifier == QuestionIdentifier.Right)
            {
                if(questTrigger == 1 || questTrigger == 2)
                {
                    popup?.SetActive(true);
                }

                QuestManager.Instance.ProceedQuest(questTrigger);
                QuestManager.Instance.UpdateScore(score);
                Destroy(this.gameObject);

                VAFeedback.Instance.RightAnswer(this.transform);
            }
            else if(identifier == QuestionIdentifier.Wrong)
            {
                QuestManager.Instance.UpdateScore(-score);
                VAFeedback.Instance.WrongAnswer(this.transform);
                Destroy(this.gameObject);
            }
        }
    }
}