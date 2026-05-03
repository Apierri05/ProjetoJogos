using UnityEngine;

/**
* classe helper para definir a movimentacao
* do jogador
*/
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour{

	[SerializeField] private CharacterStats stats;
	[SerializeField] private Animator animator;

	private Rigidbody2D rb;
	private float playerSpeed;
	private bool isFacingRight = true;

	public bool IsMoving => Mathf.Abs(rb.linearVelocity.x) > 0.1f;
	public bool IsFacingRight => isFacingRight;
	public Animator Animator => animator;

	private void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

	// recebe da classe do player o valor da direcao
	// dir < 0 o cara esta indo para a esquerda
	// dir > 0 o cara esta indo para a direita
	public void MovementDirection(float dir){
		playerSpeed = dir;

		if(dir == 0){
			animator.SetBool("isRunning", false);
		}
		else{
			animator.SetBool("isRunning", true);
		}
	}

	private void FixedUpdate(){
		HaveToFlip();
		rb.linearVelocity = new Vector2(playerSpeed * stats.moveSpeed, rb.linearVelocity.y);
	}

	public void HaveToFlip(){
		// se o boneco da olhando para a esquerda
		// e o movimento for para a direita
		// vira o boneco
		if(playerSpeed > 0 && !isFacingRight) Flip();

		// msm coisa para o lado contrario
		if(playerSpeed < 0 && isFacingRight) Flip();
	}

	public void Flip(){
		isFacingRight = !isFacingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
