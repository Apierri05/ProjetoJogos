using UnityEngine;

public class AlexandrePlayer : PlayerController
{
    protected override KeyCode LeftKey     => KeyCode.A;
    protected override KeyCode RightKey    => KeyCode.D;
    protected override KeyCode JumpKey     => KeyCode.W;
    protected override KeyCode InteractKey => KeyCode.S;

    private RaioAlexandre raio;
	
	public AudioSource audioSource;

    protected override void Awake()
    {
        base.Awake();
        raio = GetComponent<RaioAlexandre>();
    }

    protected override void Interact()
    {
		audioSource.PlayOneShot(audioSource.clip);
        raio.Atirar();
        if (movement.Animator != null)
        {
            Debug.Log("Animator OK, disparando trigger atirarRaio");
            movement.Animator.SetTrigger("atirarRaio");
        }
        else
            Debug.LogError("Animator esta nulo no Movement do Alexandre");
    }
}
