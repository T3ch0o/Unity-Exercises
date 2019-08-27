using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D RigidBody2;

    private Vector2 _movement;

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        RigidBody2.MovePosition(RigidBody2.position + _movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
