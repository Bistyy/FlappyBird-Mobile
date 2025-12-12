using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}