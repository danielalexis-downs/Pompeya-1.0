using UnityEngine;

public class Movement : MonoBehaviour
{
public float Speed = 5f;
public float JumpForce = 300f;
    private Rigidbody2D Rigidbody2D;

    //private Animator Animator;

    private float Horizontal;

    private bool Grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        //Animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if(Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        //Animator.SetBool("running", Horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.2f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.2f))
        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }

    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
    
private void FixedUpdate()
{
    Rigidbody2D.linearVelocity = new Vector2(Horizontal * Speed, Rigidbody2D.linearVelocity.y);
}

}

