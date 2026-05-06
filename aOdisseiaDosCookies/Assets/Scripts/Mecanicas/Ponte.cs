using UnityEngine;

public class Ponte : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private SpriteRenderer spriteRenderer;
    private Collider2D col;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        spriteRenderer.enabled = false;
        col.enabled = false;
    }

    public void Ativar()
    {
        spriteRenderer.enabled = true;
        col.enabled = true;
        audioSource.PlayOneShot(audioSource.clip);
    }
}
