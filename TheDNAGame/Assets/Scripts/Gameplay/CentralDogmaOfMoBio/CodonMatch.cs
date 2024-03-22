using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodonMatch : MonoBehaviour
{
    public Nucleotide nucleotideToMatch;
    public Material materialToChange;
    public Renderer _renderer;

    public bool isMatch(Nucleotide _nucleotide)
    {
        if (_nucleotide == nucleotideToMatch)
        {
            _renderer.material = materialToChange;
            return true;
        }
        else return false;
    }
}