using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] public float speed = 3f;  // Public for spawner

    void Update() { transform.Translate(Vector3.left * speed * Time.deltaTime); }

    void OnBecameInvisible() { Destroy(gameObject); }  // Clean up
}