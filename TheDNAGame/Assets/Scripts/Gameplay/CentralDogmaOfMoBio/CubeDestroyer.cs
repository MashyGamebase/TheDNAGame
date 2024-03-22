using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nucleotide"))
        {
            Destroy(other.gameObject);
        }
    }
}