using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
 public float fallDelay = 0.2f;
    public float fallSpeed = 0.8f;

    private bool isFalling = false;
    private float fallTimer = 0f;

    void Update()
    {
        if (isFalling)
        {
            fallTimer -= Time.deltaTime;

            if (fallTimer <= 0f)
            {
                transform.position += Vector3.down * fallSpeed * Time.deltaTime;
            }
        }

        if (transform.position.y < Camera.main.transform.position.y - 10f)
        {
        Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (!isFalling)
            {
                isFalling = true;
                fallTimer = fallDelay;
            }
        }
    }
}