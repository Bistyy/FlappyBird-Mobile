using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Destroy when far off-screen left (saves performance)
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
}