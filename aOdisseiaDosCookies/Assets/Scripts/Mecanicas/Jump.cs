using UnityEngine;

/**
* classe auxiliar para facilitar implementacao
* do pulo do boneco, seus metodos sao chamados na
* classe player
*/
public class Jump : MonoBehaviour
{
    [SerializeField] private CharacterStats stats;
    [SerializeField] private Transform groundCheck;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool hasDoubleJump;

    public bool IsGrounded => isGrounded;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        CheckGround();
    }
	

    private void CheckGround(){
        bool wasGrounded = isGrounded;
        Collider2D hit = Physics2D.OverlapCircle(
            groundCheck.position,
            stats.groundCheckRadius,
            stats.groundLayer
        );
        isGrounded = hit != null;

        // somente restaura o pulo duplo se tocar no chao de novo
        if (!wasGrounded && isGrounded)
            hasDoubleJump = stats.canDoubleJump;
    }
	
	// verifica se o cara esta no chao antes de pular, para evitar pulo duplo
    public void TryJump(){
		//Debug.Log("Personagem esta tentando pular");
        if (isGrounded){
			//Debug.Log("Pulo saindo do chao");
            PerformJump();
            hasDoubleJump = stats.canDoubleJump;
        }
        else if (hasDoubleJump){
			//Debug.Log("Double Jump");
            PerformJump();
            hasDoubleJump = false;
        }
    }

    private void PerformJump(){
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // zera velocidade vertical
        rb.AddForce(Vector2.up * stats.jumpForce, ForceMode2D.Impulse);
    }
}
