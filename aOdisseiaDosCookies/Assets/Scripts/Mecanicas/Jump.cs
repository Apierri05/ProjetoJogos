using UnityEngine;

/**
* classe auxiliar para facilitar implementacao
* do pulo do boneco, seus metodos sao chamados na
* classe player
*/
public class Jump : MonoBehaviour
{
    [SerializeField] private CharacterStats stats;
    [SerializeField] private Transform      groundCheck;

    private Rigidbody2D rb;
    private bool        isGrounded;
    private bool        hasDoubleJump;

    public bool IsGrounded => isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CheckGround();
    }

    private void CheckGround()
    {
        bool wasGrounded = isGrounded;
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            stats.groundCheckRadius,
            stats.groundLayer
        );

        // Ao tocar o chão, restaura o double jump
        if (!wasGrounded && isGrounded)
            hasDoubleJump = stats.canDoubleJump;
    }

    // Chamado pelo PlayerInput quando o botão de pulo é pressionado
    public void TryJump()
    {
        if (isGrounded)
        {
            PerformJump();
            hasDoubleJump = stats.canDoubleJump;
        }
        else if (hasDoubleJump)
        {
            PerformJump();
            hasDoubleJump = false;
        }
    }

    private void PerformJump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // zera velocidade vertical
        rb.AddForce(Vector2.up * stats.jumpForce, ForceMode2D.Impulse);
    }
}
