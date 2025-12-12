using UnityEngine;

public class PipeScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird")) FindObjectOfType<GameManager>().AddScore();
    }
}