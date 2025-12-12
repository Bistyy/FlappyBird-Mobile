using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float flapForce = 7f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Keyboard (for PC testing)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * flapForce;
        }

        // Mobile touch (works automatically when built to phone)
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.linearVelocity = Vector2.up * flapForce;
        }

        // Rotation (same as before)
        float angle = Mathf.Atan2(rb.linearVelocity.y, 1f) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Lerp(transform.rotation,
            Quaternion.Euler(0, 0, Mathf.Clamp(angle, -45f, 45f)), 10f * Time.deltaTime);
    }
}