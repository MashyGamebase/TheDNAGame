using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public int questTrigger;
    public int score;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (QuestManager.Instance.currentQuest == questTrigger)
            {
                QuestManager.Instance.ProceedQuest(questTrigger);
                QuestManager.Instance.UpdateScore(score);
                Destroy(this.gameObject);
            }
        }
    }
}