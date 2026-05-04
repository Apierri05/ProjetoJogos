using System.Collections;
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
            movement.Animator.SetBool("atirarRaio", true);
            StartCoroutine(ResetAtirarRaio());
        }
        else
            Debug.LogError("Animator esta nulo no Movement do Alexandre");
    }

    private IEnumerator ResetAtirarRaio()
    {
        yield return new WaitForSeconds(0.6f);
        movement.Animator.SetBool("atirarRaio", false);
    }
}
