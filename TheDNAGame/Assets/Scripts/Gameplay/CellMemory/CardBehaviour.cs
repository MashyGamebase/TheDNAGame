using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Answer,
    Description
}

public class CardBehaviour : MonoBehaviour
{
    private Animator animator;

    public Type type;

    public int ansID;
    public int descID;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void OnMouseDown()
    {
        animator.SetTrigger("flipTrigger");
        Invoke("Flip", 0.25f);
    }

    void Flip()
    {
        if(transform.rotation == Quaternion.Euler(0, 0, 180))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }
}