using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ProjetilComeCome : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float tempoVida  = 4f;

    public void Lancar(Vector2 direcao)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.linearVelocity = direcao.normalized * velocidade;
        Destroy(gameObject, tempoVida);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.MorrerJogadores();
            Destroy(gameObject);
        }
    }
}
