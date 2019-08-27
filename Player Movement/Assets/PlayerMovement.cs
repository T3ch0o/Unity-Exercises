using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D RigidBody2;
    public Animator Animator;

    private Vector2 _movement;

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        Animator.SetFloat("Horizontal", _movement.x);
        Animator.SetFloat("Vertical", _movement.y);
        Animator.SetFloat("Speed", _movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        RigidBody2.MovePosition(RigidBody2.position + _movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
