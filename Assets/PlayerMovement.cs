using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        movement = Input.GetKey(KeyCode.LeftArrow) ? Vector2.left : Input.GetKey(KeyCode.RightArrow) ? Vector2.right : Vector2.zero;
    }

    void FixedUpdate() => rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
}
