using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Values relating to the speed of the character 
    public float MovementSpeed = 1;
    public float JumpForce = 1;


    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Controls left/right movement on the screen
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;



        // If the spacebar is pressed, the sprite should jump
        if (Input.GetKey("space") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
    }
}

