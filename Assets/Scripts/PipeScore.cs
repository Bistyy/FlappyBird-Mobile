using UnityEngine;

public class PipeScore : MonoBehaviour
{
    bool scored = false;  // Prevent double-score

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird") && !scored)
        {
            scored = true;
            FindObjectOfType<GameManager>().AddScore();
        }
    }
}