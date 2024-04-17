using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCellPart : MonoBehaviour
{
    public CellPart thisCellPart;

    public void MatchCells(CellPart cellPart)
    {
        if (thisCellPart == cellPart)
        {
            Debug.Log("Matched Cell part");
        }
        else
        {
            Debug.Log("Doesn't match");
        }
    }
}