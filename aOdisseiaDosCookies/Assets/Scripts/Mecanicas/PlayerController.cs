using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Jump))]
public abstract class PlayerController : MonoBehaviour
{
    protected abstract KeyCode LeftKey     { get; }
    protected abstract KeyCode RightKey    { get; }
    protected abstract KeyCode JumpKey     { get; }
    protected abstract KeyCode InteractKey { get; }

    private Movement movement;
    private Jump jump;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        jump = GetComponent<Jump>();
    }

    private void Update()
    {
        float dir = 0.0f;
        if (Input.GetKey(LeftKey))  dir -= 1.0f;
        if (Input.GetKey(RightKey)) dir += 1.0f;
        movement.MovementDirection(dir);

        if (Input.GetKeyDown(JumpKey)) jump.TryJump();
        if (Input.GetKeyDown(InteractKey)) Interact();
    }

    protected abstract void Interact();
}
