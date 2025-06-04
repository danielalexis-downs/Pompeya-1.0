using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float delayBeforeFall = 0.5f;
    private bool touched = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && !touched)
        {
            touched = true;
            Invoke("Drop", delayBeforeFall);
        }
    }
    
        void Drop() {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
