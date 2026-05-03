using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Jump))]
public abstract class PlayerController : MonoBehaviour
{
    protected abstract KeyCode LeftKey     { get; }
    protected abstract KeyCode RightKey    { get; }
    protected abstract KeyCode JumpKey     { get; }
    protected abstract KeyCode InteractKey { get; }

    protected Movement movement;
    private Jump jump;

    protected virtual void Awake()
    {
        movement = GetComponent<Movement>();
        jump = GetComponent<Jump>();
    }

    protected virtual void Update()
    {
        float dir = 0.0f;
        if (Input.GetKey(LeftKey))  dir -= 1.0f;
        if (Input.GetKey(RightKey)) dir += 1.0f;
        movement.MovementDirection(dir);

        if (Input.GetKeyDown(JumpKey)) jump.TryJump();
        if (Input.GetKeyDown(InteractKey))
        {
            Debug.Log($"[{GetType().Name}] Interact detectado - tecla {InteractKey}");
            Interact();
        }
    }

    protected abstract void Interact();
}
